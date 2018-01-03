using System;
using System.Collections.Generic;
using System.Linq;
using JasminSharp.Helpers;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using MathLang.Tree.Scopes.Exceptions;
using MathLang.Extensions;
using MathLang.Tree.Nodes;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Semantics
{
    public static class Preprocessor
    {
        private const string MainClassName = "Main";
        private const string MainFuncName = "Main";

        #region PreProcss

        public static void PreProcess(this Nodes.Program program)
        {
            var scope = program.Scope;
            program.ClassNodes.ForEach(classDeclaration =>
            {
                classDeclaration.CheckName(scope);
                scope.AddClass(classDeclaration);
                classDeclaration.PreProcess();

                //FunctionDeclaration func = classDeclaration.Scope.LocalFunctionSearch(MainClassName);
                //if(func != null && classDeclaration.IsStatic)
                //    throw new ScopeException("Main function must be declared inside of a non static class");
                //if(func != null && mainFunction != null)
                //    throw new ScopeException("Only 1 Main function can be present");
                //mainFunction = func ?? mainFunction;
            });
            CheckMainClass(program);
        }

        private static void PreProcess(this ClassDeclaration classDeclaration)
        {
            var scope = classDeclaration.Scope;

            var duplicatedModifiers = classDeclaration.ModifiersList
                .GetDuplicatedItems().ToList();
            if (duplicatedModifiers.Any())
                throw new ScopeException($"Modifier {duplicatedModifiers.First()} was specified more than once");

//            classDeclaration.ModifiersList.ForEach(modifier =>
//            {
//                if (modifier == Modifier.Static) classDeclaration.IsStatic = true;
//                if (modifier == Modifier.Extern) classDeclaration.IsExtern = true;
//            });

            classDeclaration.FunctionDeclarationNodes
                .ForEach(functionDeclaration =>
                {
                    functionDeclaration.CheckName(scope);
                    scope.AddFunction(functionDeclaration);
                    functionDeclaration.PreProcess();
                });

            classDeclaration.VarDeclarationNodes
                .ForEach(declaration =>
                {
                    declaration.CheckName(scope);
                    scope.AddVariable(declaration);
                });
        }

        private static void PreProcess(this FunctionDeclaration functionDeclaration)
        {
            functionDeclaration.ParameterNodes
                .ForEach(parameter =>
                {
                    parameter.CheckName(functionDeclaration.Scope);
                    functionDeclaration.Scope.AddVariable(parameter);
                });
        }

        private static void CheckMainClass(this Nodes.Program program)
        {
            var mainClass = program.Scope.LocalClassSearch(MainClassName);
            if (mainClass == null)
                throw new ScopeException("Program must contain a class\"Main\"");
            var mainFunc = mainClass.Scope.LocalFunctionSearch(MainFuncName);
            if (mainFunc == null)
                throw new ScopeException("Program must contain a \"Main\" function inside of Main class");
        }

        #endregion

        #region Process

        public static void Process(this Nodes.Program program)
        {
            program.ClassNodes.ForEach(Process);
        }

        #region Declarations

        private static void Process(this ClassDeclaration classDeclaration)
        {
            classDeclaration.FunctionDeclarationNodes.ForEach(Process);
            classDeclaration.VarDeclarationNodes.ForEach(declaration => declaration.Process(false));
        }

        private static void Process(this VariableDeclaration variableDeclaration, bool checkName = true,
            int? upTpLevel = null)
        {
            //Process assignment value
            if (checkName)
            {
                //variableDeclaration.CheckName(variableDeclaration.Scope);
                if (variableDeclaration.Scope.GlobalVariableSearch(
                        variableDeclaration.Name, Scope.FunctionLevel)
                    != null)
                    throw new ScopeException($"Variable with name: \"{variableDeclaration.Name}\" already exists");
                variableDeclaration.Scope.AddVariable(variableDeclaration);
            }

            if (variableDeclaration.IsField)
            {
                var parentClass = variableDeclaration.Parent.CastTo<ClassDeclaration>();
                if (parentClass.IsStatic && !variableDeclaration.IsStatic)
                    throw new ScopeException(
                        $"Static class {parentClass.Name} can not contain a non static field {variableDeclaration.Name}");
            }

            if (!variableDeclaration.IsField && variableDeclaration.Modifier != 0)
            {
                var enumerable = variableDeclaration.Modifier.GetFlagsWithoutDefault<Modifier>().ToList();
                throw new ScopeException(
                    $"Local variables can not have modifiers: \"{string.Join(", ", enumerable)}\"" +
                    $" ({variableDeclaration.FullName} in {variableDeclaration.Parent})");
            }

            IExpression variableDeclarationValueExpression = variableDeclaration.Value;
            if (variableDeclarationValueExpression != null)
            {
                variableDeclarationValueExpression.Process();

                if (!(variableDeclaration.TypeDefinition == variableDeclarationValueExpression.TypeDefinition))
                {
                    if (variableDeclarationValueExpression.TypeDefinition.IsCastableTo(variableDeclaration
                        .TypeDefinition))
                    {
                        variableDeclarationValueExpression.CastToType = variableDeclaration.TypeDefinition;
                    }
                    else
                    {
                        throw new ScopeException(
                            $"Variable \"{variableDeclaration.Name}\" return type {variableDeclaration.TypeDefinition} is different from {variableDeclarationValueExpression.TypeDefinition} ");
                    }
                }
            }
        }

        private static void Process(this FunctionDeclaration functionDeclaration)
        {
            functionDeclaration.ModifiersList.ForEach(modifier =>
            {
                switch (modifier)
                {
                    case Modifier.Static:
                        if (functionDeclaration.IsStatic)
                            throw new ScopeException($"Modifier {modifier} is used more than one time");
                        functionDeclaration.IsStatic = true;
                        break;
                    case Modifier.Extern:
                        if (functionDeclaration.IsExternal)
                            throw new ScopeException($"Modifier {modifier} is used more than one time");
                        functionDeclaration.IsExternal = true;
                        break;
                }
            });

            if (functionDeclaration.IsExternal)
            {
                if (functionDeclaration.StatementBlock != null)
                {
                    throw new ScopeException(
                        $"Extern function {functionDeclaration.Name} can not have a declaration body");
                }
            }
            else
            {
                var scope = functionDeclaration.Scope;
                functionDeclaration.StatementBlock.Statements
                    .ForEach(statement => statement.Process());

                if (functionDeclaration.TypeDefinition != TypeDefinition.Void)
                {
                    var returnStatements =
                        functionDeclaration.StatementBlock.Statements
                            .FindAll(statement => statement is ReturnStatement)
                            .Cast<ReturnStatement>()
                            .ToList();
                    if (returnStatements.Count == 0)
                        throw new ExpressionException(
                            $"Function {functionDeclaration.Name} missing a return statement");
                    returnStatements.ForEach(statement =>
                    {
                        //statement.Process();
                        if (statement.ReturnExpression.GetResultReturnType() != functionDeclaration.TypeDefinition)
                        {
                            throw new ExpressionException(
                                $"Function {functionDeclaration.Name} must return {functionDeclaration.TypeDefinition} but returns {statement.ReturnExpression.GetResultReturnType()}");
                        }
                    });
                }
            }
            functionDeclaration.AttributeUsages.ForEach(ProcessAttributeUsage);
        }

        #endregion


        #region Expressions

        private static void Process(this IExpression iexpression)
        {
            switch (iexpression)
            {
                case ExtendedId extendedId:
                    extendedId.Process();
                    break;
                case Expression expression:
                    expression.Process();
                    break;
                case Atom atom:
                    atom.Process();
                    break;
                case FunctionCall functionCall:
                    functionCall.Process();
                    break;
                case NewArray newArray:
                    newArray.Process();
                    break;
                case ArrayElementReference arrayElementReference:
                    arrayElementReference.Process();
                    break;
                case NewExpression newExpression:
                    newExpression.ProcessNewExpression();
                    break;
                default: throw new ArgumentOutOfRangeException(nameof(iexpression));
            }
        }

        private static void Process(this ExtendedId extendedId, bool isVariable = true)
        {
            var scope = extendedId.Scope;
            if (isVariable)
            {
                var declaration = scope.GlobalVariableSearch(extendedId.Name);
                if (declaration == null)
                    throw new ScopeException($"Variable with name \"{extendedId.Name}\" does not exist");
                extendedId.VariableDeclaration = declaration;
                if (!declaration.Initialized)
                    throw new ScopeException(
                        $"Variable with name \"{extendedId.Name}\" was not initialized before accessing");
                extendedId.TypeDefinition = declaration.TypeDefinition;
            }
            else
            {
                FunctionDeclaration declaration = scope.GlobalFunctionSearch(extendedId.Name);
                extendedId.TypeDefinition = declaration != null
                    ? declaration.TypeDefinition
                    : throw new ScopeException($"Variable with name \"{extendedId.Name}\" does not exist.");
            }
        }

        private static void Process(this Expression expression)
        {
            expression.Left.Process();
            expression.Right?.Process();

            var expressionType = expression.ExpressionType;


            if (TreeHelper.IsComparisonExpression(expressionType))
                expression.TypeDefinition = TypeDefinition.Bool;

            //HERE


            if (expression.Right == null)
            {
                expression.TypeDefinition = expression.Left.TypeDefinition;
                //if (expression.TypeDefinition == expression.Left.TypeDefinition) return;
                //if (expression.Left.TypeDefinition.IsCastableTo(expression.TypeDefinition))
                //    expression.Left.CastToType = expression.TypeDefinition;
                //else
                //    throw new ExpressionException(
                //        $"Return type {expression.Left.TypeDefinition} does not match {expression.TypeDefinition}");
            }

            else if (TreeHelper.IsComparisonExpression(expressionType))
            {
                expression.TypeDefinition = TypeDefinition.Bool;

                if (TreeHelper.IsMathematicalComparison(expressionType))
                {
                    if (expression.Left.GetResultReturnType() != expression.Right.GetResultReturnType())
                    {
                        if (expression.Right.GetResultReturnType()
                            .IsCastableTo(expression.Left.GetResultReturnType()))
                        {
                            expression.Right.CastToType = expression.Left.GetResultReturnType();
                        }
                        else
                            throw new ExpressionException(
                                $"Can not compare {expression.Left.GetResultReturnType()} to {expression.Right.GetResultReturnType()} ");
                        if (!expression.Left
                            .GetResultReturnType()
                            .IsMathematicallyComparisonable())
                            throw new ExpressionException(
                                $"Can not apply operation {expression.ExpressionType} to types {expression.Left.GetResultReturnType()}");
                    }
                }
                if (TreeHelper.IsBooleanComparison(expressionType))
                {
                    if (expression.Left.GetResultReturnType() != TypeDefinition.Bool)
                        throw new ExpressionException($"Left operand must be of type {TypeDefinition.Bool}");
                    if (expression.Right.GetResultReturnType() != TypeDefinition.Bool)
                        throw new ExpressionException($"Right operand must be of type {TypeDefinition.Bool}");
                }
            }

            else if (expression.Left.TypeDefinition != expression.Right.TypeDefinition)
                if (expression.Right.TypeDefinition.IsCastableTo(expression.Left.TypeDefinition))
                {
                    expression.TypeDefinition = expression.Left.TypeDefinition;
                    expression.Right.CastToType = expression.Left.TypeDefinition;
                }
                else
                    throw new ExpressionException(
                        $"Can not cast {expression.Left.TypeDefinition} to type {expression.Right.TypeDefinition}");
            else
                expression.TypeDefinition = expression.Left.TypeDefinition;
        }

        private static void Process(this Atom atom)
        {
            //Nothing to do now
            //throw new InvalidOperationException("atom");
        }

        private static void Process(this FunctionCall functionCall)
        {
            //functionCall.Name.Process();
            var functionDeclaration = functionCall.Scope.GlobalFunctionSearch(functionCall.ExtendedId.Name);
            if (functionDeclaration == null)
                throw new ScopeException($"Function with name \"{functionCall.ExtendedId.Name}\" does not exist");

            CheckCallParameters(functionCall, functionCall.FunctionCallParameters, functionDeclaration.ParameterNodes);
            functionCall.TypeDefinition = functionDeclaration.TypeDefinition;
        }

        private static void CheckCallParameters(INode invoker, IList<IExpression> callParameters,
            IList<FunctionVariableDeclarationParameter> declarationParameters)
        {
            if (declarationParameters.Count != callParameters.Count)
                throw new ScopeException(
                    $"Function \"{invoker}\" call signature is different from defined function with that name");
            for (int i = 0; i < declarationParameters.Count; i++)
            {
                var parameter = declarationParameters[i];
                var callParameter = callParameters[i];
                callParameter.Process();

                if (parameter.TypeDefinition == callParameter.TypeDefinition) continue;
                if (callParameter.TypeDefinition.IsCastableTo(parameter.TypeDefinition))
                    callParameter.CastToType = parameter.TypeDefinition;
                else
                    throw new ScopeException(
                        $"Type {callParameter.TypeDefinition} can not be matched to type {parameter.TypeDefinition} in {invoker}");
            }
        }

        private static void Process(this NewArray newArray)
        {
            if (newArray.ArraySize != null && newArray.InitializationParameters.Count > 0)
                throw new ScopeException("You can't specify array size and include initialization parameters");
            if (newArray.ArraySize == null && newArray.InitializationParameters.Count == 0)
                throw new ScopeException("You must specify array size");
            if (newArray.ArraySize != null)
            {
                newArray.ArraySize.Process();
                if (newArray.ArraySize.TypeDefinition != TypeDefinition.Int)
                    throw new ScopeException(
                        $"Array size must be of {TypeDefinition.Int} type, but {newArray.ArraySize.TypeDefinition} is specified");
            }
            var arrayInnerType = newArray.TypeDefinition.CastTo<ArrayTypeDefinition>()
                .InnerTypeDefinition;
            newArray.InitializationParameters.ForEach(expression =>
            {
                expression.Process();
                if (expression.TypeDefinition != arrayInnerType)
                {
                    if (expression.TypeDefinition.IsCastableTo(arrayInnerType))
                        expression.CastToType = arrayInnerType;
                    else
                        throw new ScopeException(
                            $"Initialization parameter must be of type {arrayInnerType}, but received {expression.TypeDefinition}");
                }
            });
        }

        private static void Process(this ArrayElementReference arrayElementReference)
        {
            arrayElementReference.Name.Process();
            if (arrayElementReference.Name.TypeDefinition is ArrayTypeDefinition arrayReturnType)
                arrayElementReference.TypeDefinition = arrayReturnType.InnerTypeDefinition;
            else
                throw new ExpressionException(
                    $"Variable \"{arrayElementReference.Name}\" is of type {arrayElementReference.Name.TypeDefinition} but expected array");

            arrayElementReference.ArrayIndex.Process();
            if (arrayElementReference.ArrayIndex.GetResultReturnType() != TypeDefinition.Int)
                throw new ExpressionException(
                    $"Index of array element reference \"{arrayElementReference.Name}\" must be of type {TypeDefinition.Int}, but received {arrayElementReference.ArrayIndex.TypeDefinition}");
            arrayElementReference.ArrayDeclaration = arrayElementReference.Scope
                .GlobalVariableSearch(arrayElementReference.Name.Name);
        }

        private static void ProcessNewExpression(this NewExpression newExpression)
        {
        }

        #endregion

        #region Statements

        private static void Process(this IStatement statement)
        {
            switch (statement)
            {
                case VariableAssignment variableAssignment:
                    variableAssignment.Process();
                    break;
                case ArrayElementAssignment arrayElementAssignment:
                    arrayElementAssignment.Process();
                    break;
                case VariableDeclaration declaration:
                    declaration.Process();
                    break;
                case FunctionCall functionCall:
                    functionCall.Process();
                    break;
                case ReturnStatement returnStatement:
                    returnStatement.Process();
                    break;
                case WhileStatement whileStatement:
                    whileStatement.Process();
                    break;
                case IfStatement ifStatement:
                    ifStatement.Process();
                    break;
                case ForStatement forStatement:
                    forStatement.Process();
                    break;
                case BlockStatement blockStatement:
                    blockStatement.Process();
                    break;
                default:
                    throw new NotImplementedException($"Statements process: {statement.GetType()}");
            }
        }

        private static void Process(this VariableAssignment variableAssignment)
        {
            var scope = variableAssignment;

            variableAssignment.VariableName.Process();
            var variableReturnType = variableAssignment.VariableName.TypeDefinition;
            var assignmentValue = variableAssignment.AssignmentValue;

            assignmentValue.Process();

            if (assignmentValue.TypeDefinition != variableReturnType)
            {
                if (assignmentValue.TypeDefinition.IsCastableTo(variableReturnType))
                {
                    assignmentValue.CastToType = variableReturnType;
                }
                else
                    throw new ScopeException(
                        $"Return type {assignmentValue.TypeDefinition} does not match {variableReturnType}");
            }
        }

        private static void Process(this ArrayElementAssignment arrayElementAssignment)
        {
            arrayElementAssignment.ArrayElementReference.Process();
            arrayElementAssignment.AssignmentExpression.Process();

            var arrItemType = arrayElementAssignment.ArrayElementReference.TypeDefinition
                //.CastTo<ArrayTypeDefinition>()
                //.InnerTypeDefinition
                ;

            if (arrItemType != arrayElementAssignment.AssignmentExpression.TypeDefinition)
            {
                if (arrayElementAssignment.AssignmentExpression.TypeDefinition.IsCastableTo(arrItemType))
                {
                    arrayElementAssignment.AssignmentExpression.CastToType = arrItemType;
                }

                else
                {
                    throw new ExpressionException($"Cannot assign to the element of array " +
                                                  $"{arrayElementAssignment.ArrayElementReference.Name} " +
                                                  $"({arrayElementAssignment.ArrayElementReference.TypeDefinition}) " +
                                                  $"expression of type {arrayElementAssignment.AssignmentExpression.TypeDefinition}");
                }
            }

            //blockStatement.Statements.ForEach(st => st.Process());
        }

        private static void Process(this ReturnStatement returnStatement)
        {
            returnStatement.ReturnExpression.Process();
            var retType = returnStatement.ReturnExpression.TypeDefinition;

            INode node = returnStatement.Parent;

            while (!(node is FunctionDeclaration))
            {
                node = node.Parent;
            }

            var funcDecl = node as FunctionDeclaration;

            if (funcDecl.TypeDefinition != retType)
            {
                if (retType.IsCastableTo(funcDecl.TypeDefinition))
                {
                    returnStatement.ReturnExpression.CastToType = funcDecl.TypeDefinition;
                }
                else
                {
                    throw new ExpressionException($"Return type of func {(node as FunctionDeclaration).Name} " +
                                                  $"({(node as FunctionDeclaration).TypeDefinition}) does not match {retType}");
                }
            }
        }

        private static void Process(this WhileStatement whileStatement)
        {
            whileStatement.ConditionExpression.Process();

            if (whileStatement.ConditionExpression.TypeDefinition != TypeDefinition.Bool)
            {
                throw new ExpressionException($"conditional expression in while must be of type bool, not " +
                                              $"{whileStatement.ConditionExpression.TypeDefinition}");
            }

            whileStatement.BlockOrSingleStatement.Process();
        }

        private static void Process(this IfStatement ifStatement)
        {
            ifStatement.ConditionExpression.Process();
            if (ifStatement.ConditionExpression.TypeDefinition != TypeDefinition.Bool)
            {
                throw new ExpressionException($"conditional expression in if must be of type bool, not " +
                                              $"{ifStatement.ConditionExpression.TypeDefinition}");
            }
            ifStatement.TrueCaseBlockStatement.Process();

            if (ifStatement.FasleCaseBlockStatement != null)
            {
                ifStatement.FasleCaseBlockStatement.Process();
            }
        }

        private static void Process(this ForStatement forStatement)
        {
            if (forStatement.InitializationStatement != null)
                forStatement.InitializationStatement.Process();
            if (forStatement.ConditionExpression != null)
            {
                forStatement.ConditionExpression.Process();
                if (forStatement.ConditionExpression.TypeDefinition != TypeDefinition.Bool)
                {
                    throw new ExpressionException($"conditional expression in if must be of type bool, not " +
                                                  $"{forStatement.ConditionExpression.TypeDefinition}");
                }
            }
            if (forStatement.IterationStatement != null)
                forStatement.IterationStatement.Process();

            forStatement.BlockOrSingleStatement.Process();
        }

        private static void Process(this BlockStatement blockStatement)
        {
            blockStatement.Statements.ForEach(st => st.Process());
        }

        #endregion

        private static void ProcessAttributeUsage(this AttributeUsage attributeUsage)
        {
            ClassDeclaration classDeclaration = attributeUsage.Scope.GlobalClassSearch(attributeUsage.Name.Name);
            if (classDeclaration == null)
                throw new ScopeException($"Attribute {attributeUsage.Name.Name} was not found");
            if (!classDeclaration.IsAttribute)
                throw new ScopeException($"Class {attributeUsage.Name.Name} is not an attribute");
            AttributeDeclaration attributeDeclarationClass = classDeclaration.CastTo<AttributeDeclaration>();
            CheckCallParameters(attributeUsage, attributeUsage.FunctionCallParameters,
                attributeDeclarationClass.ParameterNodes);
        }

        #endregion

        #region After Process

        public static void SetVariableIndexes(this Nodes.Program program,
            FunctionIndexingStrategy functionIndexingStrategy)
        {
            program.ClassNodes.ForEach(classDeclaration =>
            {
                classDeclaration.FunctionDeclarationNodes.ForEach(functionDeclaration =>
                {
                    if (functionIndexingStrategy == FunctionIndexingStrategy.United)
                    {
                        int varIndex = functionDeclaration.IsStatic ? 0 : 1;
                        SetFunctionArgsIndexes(functionDeclaration, ref varIndex);
                        if (functionDeclaration.StatementBlock != null)
                            SetBlockVarsIndexes(functionDeclaration.StatementBlock, ref varIndex);
                    }
                    else if (functionIndexingStrategy == FunctionIndexingStrategy.Splitted)
                    {
                        int argumenIndex = functionDeclaration.IsStatic ? 0 : 1;
                        int localIndex = 0;
                        SetFunctionArgsIndexes(functionDeclaration, ref argumenIndex);
                        if (functionDeclaration.StatementBlock != null)
                            SetBlockVarsIndexes(functionDeclaration.StatementBlock, ref localIndex);
                    }
                });
            });

            void SetFunctionArgsIndexes(FunctionDeclaration functionDeclaration, ref int index)
            {
                foreach (var parameter in functionDeclaration.ParameterNodes)
                    parameter.Index = index++;
                //SetBlockVarsIndexes(functionDeclaration.StatementBlock, ref index);
            }

            void SetDeclarationIndex(VariableDeclaration declaration, ref int varIndex)
            {
                declaration.Index = varIndex++;
            }

            void SetBlockVarsIndexes(BlockStatement blockStatement, ref int varIndex)
            {
                foreach (var statement in blockStatement.Statements)
                    SetStatementIndexes(statement, ref varIndex);
            }

            void SetStatementIndexes(IStatement statement, ref int varIndex)
            {
                switch (statement)
                {
                    case VariableDeclaration declaration:
                    {
                        SetDeclarationIndex(declaration, ref varIndex);
                        break;
                    }
                    case BlockStatement blockStatement:
                        SetBlockVarsIndexes(blockStatement, ref varIndex);
                        break;
                    case IfStatement ifStatement:
                    {
                        SetStatementIndexes(ifStatement.TrueCaseBlockStatement, ref varIndex);
                        SetStatementIndexes(ifStatement.FasleCaseBlockStatement, ref varIndex);
                        break;
                    }
                    case WhileStatement whileStatement:
                    {
                        SetStatementIndexes(whileStatement.BlockOrSingleStatement, ref varIndex);
                        break;
                    }
                    case ForStatement forStatement:
                    {
                        SetStatementIndexes(forStatement.InitializationStatement, ref varIndex);
                        SetStatementIndexes(forStatement.BlockOrSingleStatement, ref varIndex);
                        SetStatementIndexes(forStatement.IterationStatement, ref varIndex);
                        break;
                    }
                }
            }
        }

        #endregion
    }
}