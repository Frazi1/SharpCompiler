﻿using MathLang.Tree.Nodes.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using MathLang.Tree.Semantics;

namespace MathLang.CodeGeneration
{
    public  class CodeGenerator
    {
        protected AssemblyBuilder assemblyBuilder;

        protected AssemblyName assemblyName;

        protected ModuleBuilder module;

        protected MethodBuilder mainMethodbuilder;

        protected Dictionary<string, MethodBuilder> funcsMethodBuilders = new Dictionary<string, MethodBuilder>();

        public CodeGenerator (string assName, string moduleName, Tree.Nodes.Program programNode)
        {
            // create a dynamic assembly and module 
            assemblyName = new AssemblyName();
            assemblyName.Name = assName;

            assemblyBuilder = Thread.GetDomain()
                .DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave);

            module = assemblyBuilder.DefineDynamicModule(assName + ".exe");

            GenerateProgram(programNode);

            assemblyBuilder.SetEntryPoint(mainMethodbuilder, PEFileKinds.ConsoleApplication);

            assemblyBuilder.Save(assName + ".exe");
        }

        public  void GenerateProgram(Tree.Nodes.Program programNode)
        {
            
            foreach (var classNode in programNode.ClassNodes)
            {
                GenerateClass(classNode, module);
            }
            
        }

        public  void GenerateClass(ClassDeclaration classNode, ModuleBuilder module)
        {
            if (classNode.Name == "Console") return;

            // create public static class
            TypeBuilder typeBuilder = module.DefineType(classNode.Name, TypeAttributes.Public |
                TypeAttributes.Class | TypeAttributes.Sealed | TypeAttributes.Abstract);

            foreach (var funcNode in classNode.FunctionDeclarationNodes)
            {
                GeclareFunc(funcNode, typeBuilder);
            }

            foreach (var funcNode in classNode.FunctionDeclarationNodes)
            {
                GenerateFunc(funcNode, typeBuilder);                
            }

            // ??? will it work if it calls func from another class, that is not baked yet?
            Type helloWorldType = typeBuilder.CreateType();
        }

        public void GeclareFunc(FunctionDeclaration functionDeclarationNode, TypeBuilder typeBuilder)
        {
            //get tuple of arrays of type and names of func parameters
            var typesNamesTuple = GenerationHelper.GetTypesAndNamesOfFuncParams(functionDeclarationNode.ParameterNodes);

            MethodBuilder methodbuilder;

            //the firs main will be our entry point
            if (functionDeclarationNode.Name == "Main" || mainMethodbuilder == null)
            {
                // set the entry point for the application

                methodbuilder = typeBuilder.DefineMethod("Main", MethodAttributes.HideBySig | MethodAttributes.Static |
                                                                 MethodAttributes.Public, typeof(void), new Type[] { typeof(string[]) });

                mainMethodbuilder = methodbuilder;

            }
            else
            {
                methodbuilder =
                    typeBuilder.DefineMethod(functionDeclarationNode.Name,
                        MethodAttributes.HideBySig |
                        MethodAttributes.Static |
                        MethodAttributes.Public,
                        functionDeclarationNode.ReturnType.ConvertToType(),
                        /*new Type[] { typeof(string[]) }*/
                        typesNamesTuple.Item1);

                //set names to parameters
                for (int i = 0; i < typesNamesTuple.Item2.Length; i++)
                {
                    
                    methodbuilder.DefineParameter(i, ParameterAttributes.None, typesNamesTuple.Item2[i]);
                }
            }

            funcsMethodBuilders.Add(functionDeclarationNode.Name, methodbuilder);

            //GenerateFuncStatementBlock(functionDeclarationNode.StatemenBlock, methodbuilder);
        }

        public void GenerateFunc(FunctionDeclaration functionDeclarationNode, TypeBuilder typeBuilder)
        {
            ////get tuple of arrays of type and names of func parameters
            //var typesNamesTuple = GenerationHelper.GetTypesAndNamesOfFuncParams(functionDeclarationNode.ParameterNodes);

            //MethodBuilder methodbuilder;

            ////the firs main will be our entry point
            //if (functionDeclarationNode.Name == "Main" || assemblyBuilder.EntryPoint == null)
            //{
            //    // set the entry point for the application

            //    methodbuilder = typeBuilder.DefineMethod("Main", MethodAttributes.HideBySig | MethodAttributes.Static |
            //        MethodAttributes.Public, typeof(void), new Type[] { typeof(string[]) });

            //    mainMethodbuilder = methodbuilder;

            //}
            //else
            //{
            //    methodbuilder =
            //        typeBuilder.DefineMethod(functionDeclarationNode.Name,
            //            MethodAttributes.HideBySig |
            //            MethodAttributes.Static |
            //            MethodAttributes.Public,
            //            functionDeclarationNode.ReturnType.ConvertToType(),
            //            /*new Type[] { typeof(string[]) }*/
            //            typesNamesTuple.Item1);

            //    //set names to parameters
            //    for (int i = 0; i < typesNamesTuple.Item2.Length; i++)
            //    {
            //        //todo uncomment
            //        methodbuilder.DefineParameter(i, ParameterAttributes.None, typesNamesTuple.Item2[i]);
            //    }
            //}

            if (funcsMethodBuilders.Keys.Contains(functionDeclarationNode.Name))
            {
                var methodbuilder = funcsMethodBuilders[functionDeclarationNode.Name];

                GenerateFuncStatementBlock(functionDeclarationNode.StatemenBlock, methodbuilder);
            }
            else
            {
                throw new NotSupportedException($"Cannot find func {functionDeclarationNode.Name}");
            }
        }

        public void GenerateFuncStatementBlock(BlockStatement blockStatementNode, MethodBuilder methodBuilder)
        {
            ILGenerator ilGenerator = methodBuilder.GetILGenerator();

            foreach (var statement in blockStatementNode.Statements)
            {
                GenerateStatement(statement, ilGenerator);
            }
            //ilGenerator.EmitWriteLine("Hello world");

            ilGenerator.Emit(OpCodes.Ret);
        }

        public void GenerateStatement(IStatement statement, ILGenerator ilGenerator)
        {
            switch (statement)
            {
                //case VariableAssignment variableAssignment:
                //    variableAssignment.Generate();
                //    break;
                //case ArrayElementAssignment arrayElementAssignment:
                //    arrayElementAssignment.Generate();
                //    break;
                //case Declaration declaration:
                //    declaration.Generate();
                //    break;
                case FunctionCall functionCall:
                    GenerateFuncCall(functionCall, ilGenerator);
                    break;
                //case ReturnStatement returnStatement:
                //    returnStatement.Generate();
                //    break;
                //case WhileStatement whileStatement:
                //    whileStatement.Generate();
                //    break;
                //case IfStatement ifStatement:
                //    ifStatement.Generate();
                //    break;
                //case ForStatement forStatement:
                //    forStatement.Generate();
                //    break;
                //case BlockStatement blockStatement:
                //    blockStatement.Generate();
                //    break;
                default:
                    throw new NotImplementedException($"Cannot Generate statement: {statement.GetType()}");
            }
        }

        #region statements
        public void GenerateFuncCall(FunctionCall funcCallNode, ILGenerator ilGenerator)
        {
            var ids = funcCallNode.Name.GetFullPath.Split('.');

            if (ids.Length == 2 && ids[0] == "Console")
            {
                //get argument type for Write line
                Type[] param = new Type[]
                {
                    funcCallNode.FunctionCallParameters[0].ReturnType.ConvertToType()
                };
                //generate method
                MethodInfo writeLineMI = typeof(Console).GetMethod(
                    "WriteLine",
                    param);
                //load parameter onto the stack
                GenerateExpression(funcCallNode.FunctionCallParameters[0], ilGenerator);
                //call WriteLine
                ilGenerator.EmitCall(OpCodes.Call, writeLineMI, null);
            }
            if (ids.Length == 1)
            {
                foreach (var functionCallParameter in funcCallNode.FunctionCallParameters)
                {
                    GenerateExpression(functionCallParameter, ilGenerator);
                }

                if (funcsMethodBuilders.Keys.Contains(funcCallNode.Name.GetFullPath))
                {
                    var methodbuilder = funcsMethodBuilders[funcCallNode.Name.GetFullPath];

                    ilGenerator.EmitCall(OpCodes.Call, methodbuilder, null);
                }
                else
                {
                    throw new NotSupportedException($"Cannot find func {funcCallNode.Name.GetFullPath} when calling.");
                }
            }
        } 
        #endregion

        private void GenerateExpression(IExpression iexpression, ILGenerator ilGenerator)
        {
            switch (iexpression)
            {
                case ExtendedId extendedId:
                    GenerateExtendedId(extendedId, ilGenerator);
                    break;
                //case Expression expression:
                //    expression.Generate();
                //    break;
                case Atom atom:
                    GenerateAtom(atom, ilGenerator);
                    break;
                //case FunctionCall functionCall:
                //    functionCall.Generate();
                //    break;
                //case NewArray newArray:
                //    newArray.Generate();
                //    break;
                //case ArrayElementReference arrayElementReference:
                //    arrayElementReference.Generate();
                //    break;
                default: throw new ArgumentOutOfRangeException(nameof(iexpression));
            }
        }

       

        private void GenerateExtendedId(ExtendedId extendedIdNode, ILGenerator ilGenerator)
        {
            var ids = extendedIdNode.GetFullPath.Split('.');

            //local var/func argument or this class static field
            if (ids.Length == 1 )
            {
                //local var/func argument or 
                if (extendedIdNode.Declaration != null)
                {
                    if (extendedIdNode.Declaration is FunctionDeclarationParameter fdParam)
                    {
                        
                        //wrong, very wrong
                        ilGenerator.Emit(OpCodes.Ldarg, (int)extendedIdNode.Declaration.Index);
                    }
                }
                //this class static field
                else
                {
                }
            }
        }

        private void GenerateAtom(Atom atomNode, ILGenerator ilGenerator)
        {
            //constant we put onto stack
            string value = atomNode.Value.Replace("\'", "").Replace("true", "1").Replace("false", "0");

            int num;
            if (Int32.TryParse(value, out num))
            {
                ilGenerator.Emit(OpCodes.Ldc_I4, num);
            }
            else
            {
                char ch;
                if (Char.TryParse(value, out ch))
                {
                    ilGenerator.Emit(OpCodes.Ldc_I4_S, (int) ch);
                }
                else
                {
                    throw new InvalidOperationException($"Bad value : {value}");
                }
            }



        }
    }
}