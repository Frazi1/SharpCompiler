using MathLang.Tree.Nodes.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using MathLang.Extensions;
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

        protected Dictionary<string, TypeBuilder> classTypeBuilders = new Dictionary<string, TypeBuilder>();

        /// <summary>
        /// contains both method builders (for our methods) and method infos (for external libraries methods)
        /// </summary>
        protected Dictionary<string, MethodInfo> funcsMethodBuilders = new Dictionary<string, MethodInfo>();

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
            //create all class and method builders
            foreach (var classNode in programNode.ClassNodes)
            {
                DeclareClass(classNode, module);
            }
            //generate code for all declared classes 
            foreach (var classNode in programNode.ClassNodes)
            {
                GenerateClass(classNode, module);
            }

        }

        public void DeclareClass(ClassDeclaration classNode, ModuleBuilder module)
        {
            TypeBuilder typeBuilder = null;

            if (!classNode.IsExtern)
            {
                // create public static class
                typeBuilder = module.DefineType(classNode.Name, TypeAttributes.Public |
                                                                TypeAttributes.Class | TypeAttributes.Sealed |
                                                                TypeAttributes.Abstract);

                classTypeBuilders.Add(classNode.Name, typeBuilder);
            }

            foreach (var funcNode in classNode.FunctionDeclarationNodes)
            {
                DeclareFunc(funcNode, typeBuilder);
            }

        }
        
        public void GenerateClass(ClassDeclaration classNode, ModuleBuilder module)
        {
            //we don't generate external classes, we only declare methods in them 
            //(by finding appropriate methods in external dll)
            if (classNode.IsExtern) return;
            
            TypeBuilder typeBuilder = null;

            if (classTypeBuilders.ContainsKey(classNode.Name))
            {
                typeBuilder = classTypeBuilders[classNode.Name];
            }

            if (typeBuilder == null) return;

            foreach (var funcNode in classNode.FunctionDeclarationNodes)
            {
                GenerateFunc(funcNode, typeBuilder);
            }

            // ??? will it work if it calls func from another class, that is not baked yet?
            Type helloWorldType = typeBuilder.CreateType();
        }

        public void DeclareFunc(FunctionDeclaration functionDeclarationNode, TypeBuilder typeBuilder)
        {
            if (functionDeclarationNode.IsExternal)
            {
                var attribute = functionDeclarationNode.AttributeUsages.FirstOrDefault(att => att.Name.Name == "DotNetRef");

                if (attribute == null) return;

                var paths = attribute.FunctionCallParameters[0].CastTo<StringExpression>().Value.Replace("\"", "").Split('/');

                if(paths.Count() < 2)
                    throw new ArgumentException("No class or method name in attribute");

                string className = paths[0];
                string methodName = paths[1];

                var typesNamesTuple2 = GenerationHelper.GetTypesAndNamesOfFuncParams(functionDeclarationNode.ParameterNodes);
                
                Type externalClassType = Assembly.Load(className).GetTypes().First(t => t.Name == className);//Type.GetType(className);

                if (externalClassType == null)
                    throw new ApplicationException($"No external class with name {className} found");

                MethodInfo methodInfo = externalClassType.GetMethod(methodName, typesNamesTuple2.Item1);
                
                funcsMethodBuilders.Add(functionDeclarationNode.FullName, methodInfo);

                return;
            }

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

            funcsMethodBuilders.Add(functionDeclarationNode.FullName, methodbuilder);
        }

        public void GenerateFunc(FunctionDeclaration functionDeclarationNode, TypeBuilder typeBuilder)
        {
            if(functionDeclarationNode.IsExternal) return;

            varsLocalBuilders.Clear();

            if (funcsMethodBuilders.Keys.Contains(functionDeclarationNode.FullName))
            {
                var methodbuilder = funcsMethodBuilders[functionDeclarationNode.FullName] as MethodBuilder;

                if (methodbuilder == null) return;

                GenerateFuncStatementBlock(functionDeclarationNode.StatementBlock, methodbuilder);
            }
            else
            {
                throw new NotSupportedException($"Cannot find func {functionDeclarationNode.FullName}");
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

            if (blockStatementNode.Parent is FunctionDeclaration funcDecl)
            {
                if(funcDecl.ReturnType == ReturnType.Void)
                    ilGenerator.Emit(OpCodes.Ret);
            }
            
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
                case VariableDeclaration declaration:
                    GenerateDeclaration(declaration, ilGenerator);
                    break;
                case FunctionCall functionCall:
                    GenerateFuncCall(functionCall, ilGenerator);
                    break;
                case ReturnStatement returnStatement:
                    GenerateReturnStatement(returnStatement, ilGenerator);
                    break;
                case WhileStatement whileStatement:
                    GenerateWhileStatement(whileStatement, ilGenerator);
                    break;
                case IfStatement ifStatement:
                    GenerateIfStatement(ifStatement, ilGenerator);
                    break;
                case ForStatement forStatement:
                    GenerateForStatement(forStatement, ilGenerator);
                    break;
                case BlockStatement blockStatement:
                    GenerateBlockStatement(blockStatement, ilGenerator);
                    break;
                default:
                    throw new NotImplementedException($"Cannot Generate statement: {statement.GetType()}");
            }
        }

        #region statements
        public void GenerateFuncCall(FunctionCall funcCallNode, ILGenerator ilGenerator)
        {
            //TODO CHECK .
            //var ids = funcCallNode.FunctionDeclaration.FullName.Split('/');

            //if (ids.Length == 2 && ids[0] == "Console")
            //{
            //    //get argument type for Write line
            //    Type[] param = new Type[]
            //    {
            //        funcCallNode.FunctionCallParameters[0].ReturnType.ConvertToType()
            //    };
            //    //generate method
            //    MethodInfo writeLineMI = typeof(Console).GetMethod(
            //        "WriteLine",
            //        param);
            //    //load parameter onto the stack
            //    GenerateExpression(funcCallNode.FunctionCallParameters[0], ilGenerator);
            //    //call WriteLine
            //    ilGenerator.EmitCall(OpCodes.Call, writeLineMI, null);
            //}
            //if (ids.Length == 1)
            {
                foreach (var functionCallParameter in funcCallNode.FunctionCallParameters)
                {
                    GenerateExpression(functionCallParameter, ilGenerator);
                }
                
                if (funcsMethodBuilders.Keys.Contains(funcCallNode.FunctionDeclaration.FullName))
                {
                    var methodbuilder = funcsMethodBuilders[funcCallNode.FunctionDeclaration.FullName];

                    ilGenerator.EmitCall(OpCodes.Call, methodbuilder, null);
                }
                else
                {
                    throw new NotSupportedException($"Cannot find func {funcCallNode.FunctionDeclaration.FullName} when calling.");
                }
            }
        }

        public void GenerateDeclaration(VariableDeclaration declNode, ILGenerator ilGenerator)
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
            if (varsLocalBuilders.Keys.Contains(varAssignmentNode.VariableName.VariableDeclaration.FullName))
            {
                var localBuilder = varsLocalBuilders[varAssignmentNode.VariableName.VariableDeclaration.FullName];
                //pop var from the stack and store in a value
                ilGenerator.Emit(OpCodes.Stloc, localBuilder);
            }
            //func argument var
            else
            {
                if (varAssignmentNode.VariableName.VariableDeclaration != null)
                {
                    if (varAssignmentNode.VariableName.VariableDeclaration is FunctionVariableDeclarationParameter fdParam)
                    {
                        //pop var from the stack and store in a func arg
                        ilGenerator.Emit(OpCodes.Starg, varAssignmentNode.VariableName.VariableDeclaration.Index.Value);
                    }
                }
            }
        }

        public void GenerateArrayElementAssignment(ArrayElementAssignment arrayElementAssignmentNode, ILGenerator ilGenerator)
        {
            #region load_arr_onto_stack
            //local var
            if (varsLocalBuilders.Keys.Contains(arrayElementAssignmentNode.ArrayElementReference.ArrayDeclaration.FullName))
            {
                var localBuilder = varsLocalBuilders[arrayElementAssignmentNode.ArrayElementReference.ArrayDeclaration.FullName];
                //load var into the stack
                ilGenerator.Emit(OpCodes.Ldloc, localBuilder);
            }
            //func arg
            else
            {
                if (arrayElementAssignmentNode.ArrayElementReference.Name.VariableDeclaration != null)
                {
                    if (arrayElementAssignmentNode.ArrayElementReference.Name.VariableDeclaration is FunctionVariableDeclarationParameter fdParam)
                    {
                        ilGenerator.Emit(OpCodes.Ldarg, (int)arrayElementAssignmentNode.ArrayElementReference.Name.VariableDeclaration.Index);

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
        
        public void GenerateIfStatement(IfStatement ifStatementNode, ILGenerator ilGenerator)
        {
            //ifStatementNode.TrueCaseBlockStatement
            Label trueCase = ilGenerator.DefineLabel();
            Label falseCase = ilGenerator.DefineLabel();

            GenerateExpression(ifStatementNode.ConditionExpression, ilGenerator);

            //jump if false
            ilGenerator.Emit(OpCodes.Brfalse_S, falseCase);

            GenerateStatement(ifStatementNode.TrueCaseBlockStatement, ilGenerator);

            //unconditional
            ilGenerator.Emit(OpCodes.Br_S, trueCase);

            
            ilGenerator.MarkLabel(falseCase);

            if (ifStatementNode.FasleCaseBlockStatement != null)
            {
                GenerateStatement(ifStatementNode.FasleCaseBlockStatement, ilGenerator);
            }
            
            ilGenerator.MarkLabel(trueCase);
        }

        private void GenerateForStatement(ForStatement forStatement, ILGenerator ilGenerator)
        {
            Label conditionCheck = ilGenerator.DefineLabel();
            Label forBody = ilGenerator.DefineLabel();

            GenerateStatement( forStatement.InitializationStatement, ilGenerator);

            //unconditional
            ilGenerator.Emit(OpCodes.Br_S, conditionCheck);

            ilGenerator.MarkLabel(forBody);
            
            GenerateStatement(forStatement.BlockOrSingleStatement, ilGenerator);
            
            GenerateStatement(forStatement.IterationStatement, ilGenerator);

            ilGenerator.MarkLabel(conditionCheck);
            
            GenerateExpression(forStatement.ConditionExpression, ilGenerator);

            //jump if true
            ilGenerator.Emit(OpCodes.Brtrue_S, forBody);
        }

        public void GenerateWhileStatement(WhileStatement whileStatementNode, ILGenerator ilGenerator)
        {
            Label conditionCheck = ilGenerator.DefineLabel();
            Label whileBody = ilGenerator.DefineLabel();

            //unconditional
            ilGenerator.Emit(OpCodes.Br_S, conditionCheck);

            ilGenerator.MarkLabel(whileBody);

            GenerateStatement(whileStatementNode.BlockOrSingleStatement, ilGenerator);

            ilGenerator.MarkLabel(conditionCheck);

            GenerateExpression(whileStatementNode.ConditionExpression, ilGenerator);

            //jump if true
            ilGenerator.Emit(OpCodes.Brtrue_S, whileBody);
        }

        public void GenerateBlockStatement(BlockStatement blockStatementNode, ILGenerator ilGenerator)
        {
            foreach (var statement in blockStatementNode.Statements)
            {
                GenerateStatement(statement, ilGenerator);    
            }
        }

        public void GenerateReturnStatement(ReturnStatement returnStatementNode, ILGenerator ilGenerator)
        {
            GenerateExpression(returnStatementNode.ReturnExpression, ilGenerator);
            ilGenerator.Emit(OpCodes.Ret);
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
                case FunctionCall functionCall:
                    GenerateFuncCall(functionCall, ilGenerator);
                    break;
                case NewArray newArray:
                    GenerateNewArray(newArray, ilGenerator);
                    break;
                case ArrayElementReference arrayElementReference:
                    GenerateArrayElementReference(arrayElementReference, ilGenerator);
                    break;
                default: throw new ArgumentOutOfRangeException($"Cannot find {iexpression} in expression types");
            }
        }

        

        private void GenerateExtendedId(ExtendedId extendedIdNode, ILGenerator ilGenerator)
        {
            //TODO: Check .
            var ids = extendedIdNode.VariableDeclaration.FullName.Split('.');

            //local var/func argument or this class static field
            if (ids.Length == 1)
            {
                //local var/func argument or 
                if (extendedIdNode.VariableDeclaration != null)
                {
                    if (extendedIdNode.VariableDeclaration is FunctionVariableDeclarationParameter fdParam)
                    {
                        ilGenerator.Emit(OpCodes.Ldarg, (int)extendedIdNode.VariableDeclaration.Index);

                    }
                    else
                    {
                        //ilGenerator.Emit(OpCodes.Ldloc, (int)extendedIdNode.Declaration.Index);

                        if (varsLocalBuilders.Keys.Contains(extendedIdNode.VariableDeclaration.FullName))
                        {
                            var localBuilder = varsLocalBuilders[extendedIdNode.VariableDeclaration.FullName];

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
            //string value = atomNode.Value.Replace("\'", "").Replace("true", "1").Replace("false", "0");

            switch (atomNode)
            {
                case IntExpression intExpression:
                    ilGenerator.Emit(OpCodes.Ldc_I4, intExpression.Value);
                    break;
                case BoolExpression boolExpression:
                    ilGenerator.Emit(OpCodes.Ldc_I4, boolExpression.Value ? 1 : 0);
                    break;
                case CharExpression charExpression:
                    ilGenerator.Emit(OpCodes.Ldc_I4_S, charExpression.Value);
                    break;
                default:
                    throw new InvalidOperationException($"Bad value : {atomNode.Value}");
            }
        }

        private void GenerateNewArray(NewArray newArrayNode, ILGenerator ilGenerator)
        {
            //load arr size onto stack
            GenerateExpression(newArrayNode.ArraySize, ilGenerator);
            //new array
            ilGenerator.Emit(OpCodes.Newarr, newArrayNode.ReturnType.ConvertToType(false));
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
            if (varsLocalBuilders.Keys.Contains(exId.VariableDeclaration.FullName))
            {
                var localBuilder = varsLocalBuilders[exId.VariableDeclaration.FullName];
                //pop var from the stack and store in a value
                ilGenerator.Emit(OpCodes.Stloc, localBuilder);
            }
            //func argument var
            else
            {
                if (exId.VariableDeclaration != null)
                {
                    if (exId.VariableDeclaration is FunctionVariableDeclarationParameter fdParam)
                    {
                        //pop var from the stack and store in a func arg
                        ilGenerator.Emit(OpCodes.Starg, (int)exId.VariableDeclaration.Index);

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
            if (varsLocalBuilders.Keys.Contains(extendedIdNode.VariableDeclaration.FullName))
            {
                var localBuilder = varsLocalBuilders[extendedIdNode.VariableDeclaration.FullName];

                ilGenerator.Emit(OpCodes.Ldloc, localBuilder);
            }
            else
            {
                if (extendedIdNode.VariableDeclaration != null)
                {
                    if (extendedIdNode.VariableDeclaration is FunctionVariableDeclarationParameter fdParam)
                    {
                        ilGenerator.Emit(OpCodes.Ldarg, (int)extendedIdNode.VariableDeclaration.Index);

                    }
                }
            }
        }
    }
}

