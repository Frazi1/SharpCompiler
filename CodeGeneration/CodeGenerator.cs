﻿using MathLang.Tree.Nodes.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using MathLang.Tree.Semantics;

namespace MathLang.CodeGeneration
{
    public class CodeGenerator
    {
        protected AssemblyBuilder assemblyBuilder;

        protected AssemblyName assemblyName;

        protected ModuleBuilder module;

        protected MethodBuilder mainMethodbuilder;

        protected Dictionary<string, MethodBuilder> funcsMethodBuilders = new Dictionary<string, MethodBuilder>();

        protected Dictionary<string, LocalBuilder> varsLocalBuilders = new Dictionary<string, LocalBuilder>();

        public CodeGenerator(string assName, Tree.Nodes.Program programNode)
        {
            // create a dynamic assembly and module 
            assemblyName = new AssemblyName();
            assemblyName.Name = assName;

            assemblyBuilder = Thread.GetDomain()
                .DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave);

            module = assemblyBuilder.DefineDynamicModule(assName + ".exe", true);

            GenerateProgram(programNode);

            assemblyBuilder.SetEntryPoint(mainMethodbuilder, PEFileKinds.ConsoleApplication);

            assemblyBuilder.Save(assName + ".exe");
        }

        public void GenerateProgram(Tree.Nodes.Program programNode)
        {

            foreach (var classNode in programNode.ClassNodes)
            {
                GenerateClass(classNode, module);
            }

        }

        public void GenerateClass(ClassDeclaration classNode, ModuleBuilder module)
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

                    methodbuilder.DefineParameter(i + 1, ParameterAttributes.None, typesNamesTuple.Item2[i]);
                }
            }

            funcsMethodBuilders.Add(functionDeclarationNode.Name, methodbuilder);
        }

        public void GenerateFunc(FunctionDeclaration functionDeclarationNode, TypeBuilder typeBuilder)
        {
            varsLocalBuilders.Clear();

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
                case VariableAssignment variableAssignment:
                    GenerateVarAssignment(variableAssignment, ilGenerator);
                    break;
                case ArrayElementAssignment arrayElementAssignment:
                    GenerateArrayElementAssignment(arrayElementAssignment, ilGenerator);
                    break;
                case Declaration declaration:
                    GenerateDeclaration(declaration, ilGenerator);
                    break;
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

        public void GenerateDeclaration(Declaration declNode, ILGenerator ilGenerator)
        {
            LocalBuilder localBuilder = ilGenerator.DeclareLocal(declNode.ReturnType.ConvertToType());

            localBuilder.SetLocalSymInfo(declNode.Name);
            //add our local to dictionary
            varsLocalBuilders.Add(declNode.Name, localBuilder);

            if (declNode.Value != null)
            {
                GenerateExpression(declNode.Value, ilGenerator);
                //pop var from the stack and store in a value
                ilGenerator.Emit(OpCodes.Stloc, localBuilder);
            }

        }

        public void GenerateVarAssignment(VariableAssignment varAssignmentNode, ILGenerator ilGenerator)
        {
            GenerateExpression(varAssignmentNode.AssignmentValue, ilGenerator);

            //local var
            if (varsLocalBuilders.Keys.Contains(varAssignmentNode.VariableName.GetFullPath))
            {
                var localBuilder = varsLocalBuilders[varAssignmentNode.VariableName.GetFullPath];
                //pop var from the stack and store in a value
                ilGenerator.Emit(OpCodes.Stloc, localBuilder);
            }
            //func argument var
            else
            {
                if (varAssignmentNode.VariableName.Declaration != null)
                {
                    if (varAssignmentNode.VariableName.Declaration is FunctionDeclarationParameter fdParam)
                    {
                        //pop var from the stack and store in a func arg
                        ilGenerator.Emit(OpCodes.Starg, (int)varAssignmentNode.VariableName.Declaration.Index);

                    }
                }
            }
        }

        public void GenerateArrayElementAssignment(ArrayElementAssignment arrayElementAssignmentNode, ILGenerator ilGenerator)
        {
            #region load_arr_onto_stack
            //local var
            if (varsLocalBuilders.Keys.Contains(arrayElementAssignmentNode.ArrayElementReference.Name.GetFullPath))
            {
                var localBuilder = varsLocalBuilders[arrayElementAssignmentNode.ArrayElementReference.Name.GetFullPath];
                //load var into the stack
                ilGenerator.Emit(OpCodes.Ldloc, localBuilder);
            }
            //func arg
            else
            {
                if (arrayElementAssignmentNode.ArrayElementReference.Name.Declaration != null)
                {
                    if (arrayElementAssignmentNode.ArrayElementReference.Name.Declaration is FunctionDeclarationParameter fdParam)
                    {
                        //pop var from the stack and store in a func arg
                        ilGenerator.Emit(OpCodes.Starg, (int)arrayElementAssignmentNode.ArrayElementReference.Name.Declaration.Index);

                    }
                }
            }
            #endregion

            //load arr index onto stack
            GenerateExpression(arrayElementAssignmentNode.ArrayElementReference.ArrayIndex, ilGenerator);
            //load value onto stack
            GenerateExpression(arrayElementAssignmentNode.AssignmentExpression, ilGenerator);

            if (arrayElementAssignmentNode.ArrayElementReference.ReturnType.ConvertToType() == typeof(char))
            {
                ilGenerator.Emit(OpCodes.Stelem_I2);
            }
            else
            {
                if (arrayElementAssignmentNode.ArrayElementReference.ReturnType.ConvertToType() == typeof(bool))
                {
                    ilGenerator.Emit(OpCodes.Stelem_I1);
                }
                else
                    ilGenerator.Emit(OpCodes.Stelem_I4);
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
                case Expression expression:
                    GenerateExpression(expression, ilGenerator);
                    break;
                case Atom atom:
                    GenerateAtom(atom, ilGenerator);
                    break;
                //case FunctionCall functionCall:
                //    functionCall.Generate();
                //    break;
                case NewArray newArray:
                    GenerateNewArray(newArray, ilGenerator);
                    break;
                case ArrayElementReference arrayElementReference:
                    GenerateArrayElementReference(arrayElementReference, ilGenerator);
                    break;
                default: throw new ArgumentOutOfRangeException(nameof(iexpression));
            }
        }



        private void GenerateExtendedId(ExtendedId extendedIdNode, ILGenerator ilGenerator)
        {
            var ids = extendedIdNode.GetFullPath.Split('.');

            //local var/func argument or this class static field
            if (ids.Length == 1)
            {
                //local var/func argument or 
                if (extendedIdNode.Declaration != null)
                {
                    if (extendedIdNode.Declaration is FunctionDeclarationParameter fdParam)
                    {
                        ilGenerator.Emit(OpCodes.Ldarg, (int)extendedIdNode.Declaration.Index);

                    }
                    else
                    {
                        //ilGenerator.Emit(OpCodes.Ldloc, (int)extendedIdNode.Declaration.Index);

                        if (varsLocalBuilders.Keys.Contains(extendedIdNode.GetFullPath))
                        {
                            var localBuilder = varsLocalBuilders[extendedIdNode.GetFullPath];

                            ilGenerator.Emit(OpCodes.Ldloc, localBuilder);
                        }

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
                    ilGenerator.Emit(OpCodes.Ldc_I4_S, (int)ch);
                }
                else
                {
                    throw new InvalidOperationException($"Bad value : {value}");
                }
            }



        }

        private void GenerateNewArray(NewArray newArrayNode, ILGenerator ilGenerator)
        {
            //load arr size onto stack
            GenerateExpression(newArrayNode.ArraySize, ilGenerator);
            //new array
            ilGenerator.Emit(OpCodes.Newarr, newArrayNode.ReturnType.ConvertToType());
            //pop var from stack and store

            //if (newArrayNode.Parent is Declaration declaration)
            //{
            //    PopAndStore(declaration.Name, (int)declaration.Index, ilGenerator);
            //}
            //else
            //    if (newArrayNode.Parent is VariableAssignment varAssignment)
            //    {
            //        PopAndStore(varAssignment.VariableName, ilGenerator);
            //    }
        }

        private void GenerateArrayElementReference(ArrayElementReference arrayElementReferenceNode,
            ILGenerator ilGenerator)
        {
            //load array
            LoadOntoStack(arrayElementReferenceNode.Name, ilGenerator);
            //load index
            GenerateExpression(arrayElementReferenceNode.ArrayIndex, ilGenerator);
            //load array element with index onto stack
            ilGenerator.Emit(OpCodes.Ldelem, arrayElementReferenceNode.ReturnType.ConvertToType());

        }

        private void GenerateExpression(Expression expressionNode, ILGenerator ilGenerator)
        {
            //IsMathematicalComparison

            
            {
                GenerateExpression(expressionNode.Left, ilGenerator);
                GenerateExpression(expressionNode.Right, ilGenerator);

                switch (expressionNode.ExpressionType)
                {
                    case ExpressionType.Add:
                        ilGenerator.Emit(OpCodes.Add);
                        break;
                    case ExpressionType.Sub:
                        ilGenerator.Emit(OpCodes.Sub);
                        break;
                    case ExpressionType.Mul:
                        ilGenerator.Emit(OpCodes.Mul);
                        break;
                    case ExpressionType.Div:
                        ilGenerator.Emit(OpCodes.Div);
                        break;

                    case ExpressionType.Equal:
                        ilGenerator.Emit(OpCodes.Ceq);
                        break;
                    case ExpressionType.Greater:
                        ilGenerator.Emit(OpCodes.Cgt);
                        break;
                    case ExpressionType.EqualOrGreater:
                        ilGenerator.Emit(OpCodes.Clt);
                        ilGenerator.Emit(OpCodes.Ldc_I4_0);
                        ilGenerator.Emit(OpCodes.Ceq);
                        break;
                    case ExpressionType.Less:
                        ilGenerator.Emit(OpCodes.Clt);
                        break;
                    case ExpressionType.EqualOrLess:
                        ilGenerator.Emit(OpCodes.Cgt);
                        ilGenerator.Emit(OpCodes.Ldc_I4_0);
                        ilGenerator.Emit(OpCodes.Ceq);
                        break;
                    case ExpressionType.NotEqual:
                        ilGenerator.Emit(OpCodes.Ceq);
                        ilGenerator.Emit(OpCodes.Ldc_I4_0);
                        ilGenerator.Emit(OpCodes.Ceq);
                        break;
                }
            }


            //    case ExpressionType.Not:
            //        break;
            //    case ExpressionType.Or:
            //        break;
            //    case ExpressionType.And:
            //        break;
            //    case ExpressionType.FunctionCall:
            //        break;
            //    case ExpressionType.VariableDeclaration:
            //        break;
            //    case ExpressionType.VariableReference:
            //        break;
            //    case ExpressionType.ArrayElementReference:
            //        break;
            //    default:
            //        throw new ArgumentOutOfRangeException();
            //}
        }

        private void PopAndStore(ExtendedId exId, ILGenerator ilGenerator)
        {
            //local var
            if (varsLocalBuilders.Keys.Contains(exId.GetFullPath))
            {
                var localBuilder = varsLocalBuilders[exId.GetFullPath];
                //pop var from the stack and store in a value
                ilGenerator.Emit(OpCodes.Stloc, localBuilder);
            }
            //func argument var
            else
            {
                if (exId.Declaration != null)
                {
                    if (exId.Declaration is FunctionDeclarationParameter fdParam)
                    {
                        //pop var from the stack and store in a func arg
                        ilGenerator.Emit(OpCodes.Starg, (int)exId.Declaration.Index);

                    }
                }
            }
        }

        private void PopAndStore(string name, int index, ILGenerator ilGenerator)
        {
            //local var
            if (varsLocalBuilders.Keys.Contains(name))
            {
                var localBuilder = varsLocalBuilders[name];
                //pop var from the stack and store in a value
                ilGenerator.Emit(OpCodes.Stloc, localBuilder);
            }
            //func argument var
            else
            {           //pop var from the stack and store in a func arg
                ilGenerator.Emit(OpCodes.Starg, index);

            }
        }

        private void LoadOntoStack(ExtendedId extendedIdNode, ILGenerator ilGenerator)
        {
            if (varsLocalBuilders.Keys.Contains(extendedIdNode.GetFullPath))
            {
                var localBuilder = varsLocalBuilders[extendedIdNode.GetFullPath];

                ilGenerator.Emit(OpCodes.Ldloc, localBuilder);
            }
            else
            {
                if (extendedIdNode.Declaration != null)
                {
                    if (extendedIdNode.Declaration is FunctionDeclarationParameter fdParam)
                    {
                        ilGenerator.Emit(OpCodes.Ldarg, (int)extendedIdNode.Declaration.Index);

                    }
                }
            }
        }
    }
}

