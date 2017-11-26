using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using MathLang.Tree.Scopes.Exceptions;
using Microsoft.Win32.SafeHandles;
using MathLang.Extensions;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Semantics
{
    public static class Preprocessor
    {
        #region PreProcss

        public static void PreProcess(this Nodes.Program program)
        {
            var scope = program.Scope;
            program.ClassNodes.ForEach(classDeclaration =>
            {
                classDeclaration.CheckName(scope);
                scope.AddClass(classDeclaration);
                classDeclaration.PreProcess();
            });
        }

        private static void PreProcess(this ClassDeclaration classDeclaration)
        {
            var scope = classDeclaration.Scope;

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

        //private static void Process(this Declaration declaration, bool checkName)
        //{
        //    switch (declaration)
        //    {
        //        case VariableDeclaration variableDeclaration:
        //            variableDeclaration.Process(checkName);
        //            break;
        //        case ArrayDeclaration arrayDeclaration:
        //            arrayDeclaration.Process();
        //            break;
        //    }
        //}

        private static void Process(this ArrayDeclaration arrayDeclaration)
        {
            //            throw  new NotImplementedException();
        }

        private static void Process(this Declaration variableDeclaration, bool checkName = true, int? upTpLevel = null)
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
            IExpression variableDeclarationValueExpression = variableDeclaration.Value;
            if (variableDeclarationValueExpression == null) return;
            variableDeclarationValueExpression.Process();
            if (variableDeclaration.ReturnType == variableDeclarationValueExpression.ReturnType) return;
            if (variableDeclarationValueExpression.ReturnType.IsCastableTo(variableDeclaration.ReturnType))
            {
                variableDeclarationValueExpression.CastToType = variableDeclaration.ReturnType;
            }
            else
                throw new ScopeException(
                    $"Variable \"{variableDeclaration.Name}\" return type {variableDeclaration.ReturnType} is different from {variableDeclarationValueExpression.ReturnType} ");
        }

        private static void Process(this FunctionDeclaration functionDeclaration)
        {
            var scope = functionDeclaration.Scope;
            functionDeclaration.StatemenBlock.Statements
                .ForEach(statement => statement.Process());

            if (functionDeclaration.ReturnType != ReturnType.Void)
            {
                var returnStatements =
                    functionDeclaration.StatemenBlock.Statements
                        .FindAll(statement => statement is ReturnStatement)
                        .Cast<ReturnStatement>()
                        .ToList();
                returnStatements.ForEach(statement =>
                {
                    //statement.Process();
                    if (statement.ReturnExpression.GetResultReturnType() != functionDeclaration.ReturnType)
                    {
                        throw new ExpressionException(
                            $"Function {functionDeclaration.Name} must return {functionDeclaration.ReturnType} but returns {statement.ReturnExpression.GetResultReturnType()}");
                    }
                });
            }
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
                case VariableReference variableReference:
                    variableReference.Process();
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
                default: throw new ArgumentOutOfRangeException(nameof(iexpression));
            }
        }

        private static void Process(this ExtendedId extendedId)
        {
            var scope = extendedId.Scope;
            var declaration = scope.GlobalVariableSearch(extendedId.GetFullPath);
            extendedId.ReturnType = declaration != null
                ? declaration.ReturnType
                : throw new ScopeException($"Variable with name \"{extendedId.GetFullPath}\" does not exist.");
        }

        private static void Process(this VariableReference variableReference)
        {
            throw new NotImplementedException("var ref");
            var scope = variableReference.Scope;
            var name = variableReference.Name.GetFullPath;
            var globalVariableSearchResult = scope.GlobalVariableSearch(name);
            if (globalVariableSearchResult == null)
                throw new ScopeException($"Variable with name \"{name}\" does not exist.");
            variableReference.ReturnType = globalVariableSearchResult.ReturnType;
        }

        private static void Process(this Expression expression)
        {
            expression.Left.Process();
            expression.Right?.Process();

            var expressionType = expression.ExpressionType;



            if (TreeHelper.IsComparisonExpression(expressionType))
                expression.ReturnType = ReturnType.Bool;

            //HERE


            if (expression.Right == null)
            {
                if (expression.ReturnType == expression.Left.ReturnType) return;
                if (expression.Left.ReturnType.IsCastableTo(expression.ReturnType))
                    expression.Left.CastToType = expression.ReturnType;
                else
                    throw new ExpressionException(
                        $"Return type {expression.Left.ReturnType} does not match {expression.ReturnType}");
            }

            else if (TreeHelper.IsComparisonExpression(expressionType))
            {
                expression.ReturnType = ReturnType.Bool;

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
                    if (expression.Left.GetResultReturnType() != ReturnType.Bool)
                        throw new ExpressionException($"Left operand must be of type {ReturnType.Bool}");
                    if (expression.Right.GetResultReturnType() != ReturnType.Bool)
                        throw new ExpressionException($"Right operand must be of type {ReturnType.Bool}");
                }
            }

            else if (expression.Left.ReturnType != expression.Right.ReturnType)
                if (expression.Right.ReturnType.IsCastableTo(expression.Left.ReturnType))
                {
                    expression.ReturnType = expression.Left.ReturnType;
                    expression.Right.CastToType = expression.Left.ReturnType;

                }
                else
                    throw new ExpressionException(
                        $"Can not cast {expression.Left.ReturnType} to type {expression.Right.ReturnType}");
            else
                expression.ReturnType = expression.Left.ReturnType;
        }


        private static void Process(this Atom atom)
        {
            //Nothing to do now
            //throw new InvalidOperationException("atom");
        }

        private static void Process(this FunctionCall functionCall)
        {
            //functionCall.Name.Process();
            var functionDeclaration = functionCall.Scope.GlobalFunctionSearch(functionCall.Name.GetFullPath);
            if (functionDeclaration == null)
                throw new ScopeException($"Function with name \"{functionCall.Name.GetFullPath}\" does not exist");
            if (functionDeclaration.ParameterNodes.Count != functionCall.FunctionCallParameters.Count)
                throw new ScopeException(
                    $"Function \"{functionCall.Name.GetFullPath}\" call signature is different from defined function with that name");
            for (int i = 0; i < functionDeclaration.ParameterNodes.Count; i++)
            {
                var parameter = functionDeclaration.ParameterNodes[i];
                var callParameter = functionCall.FunctionCallParameters[i];
                callParameter.Process();

                if (parameter.ReturnType == callParameter.ReturnType) continue;
                if (callParameter.ReturnType.IsCastableTo(parameter.ReturnType))
                    callParameter.CastToType = parameter.ReturnType;
                else
                    throw new ScopeException(
                        $"Type {callParameter.ReturnType} can not be matched to type {parameter.ReturnType}");
            }
            functionCall.ReturnType = functionDeclaration.ReturnType;
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
                if (newArray.ArraySize.ReturnType != ReturnType.Int)
                    throw new ScopeException(
                        $"Array size must be of {ReturnType.Int} type, but {newArray.ArraySize.ReturnType} is specified");
            }
            var arrayInnerType = newArray.ReturnType.CastTo<ArrayReturnType>()
                .InnerType;
            newArray.InitializationParameters.ForEach(expression =>
            {
                expression.Process();
                if (expression.ReturnType != arrayInnerType)
                {
                    if (expression.ReturnType.IsCastableTo(arrayInnerType))
                        expression.CastToType = arrayInnerType;
                    else
                        throw new ScopeException(
                            $"Initialization parameter must be of type {arrayInnerType}, but received {expression.ReturnType}");
                }
            });
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
                case Declaration declaration:
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
            var variableReturnType = variableAssignment.VariableName.ReturnType;
            var assignmentValue = variableAssignment.AssignmentValue;

            assignmentValue.Process();

            if (assignmentValue.ReturnType != variableReturnType)
            {
                if (assignmentValue.ReturnType.IsCastableTo(variableReturnType))
                {
                    assignmentValue.CastToType = variableReturnType;
                }
                else
                    throw new ScopeException(
                        $"Return type {assignmentValue.ReturnType} does not match {variableReturnType}");
            }
        }

        private static void Process(this ReturnStatement returnStatement)
        {
            returnStatement.ReturnExpression.Process();
            var retType = returnStatement.ReturnExpression.ReturnType;

            INode node = returnStatement.Parent;
            
            while (!(node is FunctionDeclaration))
            {
                node = node.Parent;
            }

            var funcDecl = node as FunctionDeclaration;

            if (funcDecl.ReturnType != retType)
            {
                if (retType.IsCastableTo(funcDecl.ReturnType))
                {
                    returnStatement.ReturnExpression.CastToType = funcDecl.ReturnType;
                }
                else
                {
                    throw new ExpressionException($"Return type of func {(node as FunctionDeclaration).Name} " +
                                                  $"({(node as FunctionDeclaration).ReturnType}) does not match {retType}");
                }
                
            }
        }

        private static void Process(this WhileStatement whileStatement)
        {

            whileStatement.ConditionExpression.Process();

            if(whileStatement.ConditionExpression.ReturnType != ReturnType.Bool)
            {
                throw new ExpressionException($"conditional expression in while must be of type bool, not " +
                                              $"{whileStatement.ConditionExpression.ReturnType}");
            }

            whileStatement.BlockOrSingleStatement.Process();
        }

        private static void Process(this BlockStatement blockStatement)
        {

            blockStatement.Statements.ForEach(st=>st.Process());
        }

        #endregion

        #endregion

        #region After Process

        public static void SetVariableIndexes(this Nodes.Program program)
        {
            program.ClassNodes.ForEach(classDeclaration =>
            {
                classDeclaration.FunctionDeclarationNodes.ForEach(functionDeclaration =>
                {
                    SetFunctionArgsIndexes(functionDeclaration);
                    int varIndex = 0;
                    SetBlockVarsIndexes(functionDeclaration.StatemenBlock, ref varIndex);
                });
            });

            void SetFunctionArgsIndexes(FunctionDeclaration functionDeclaration)
            {
                int index = 0;
                foreach (var parameter in functionDeclaration.ParameterNodes)
                    parameter.Index = index++;
                SetBlockVarsIndexes(functionDeclaration.StatemenBlock, ref index);
            }

            void SetBlockVarsIndexes(BlockStatement blockStatement, ref int varIndex)
            {
                foreach (var statement in blockStatement.Statements)
                    switch (statement)
                    {
                        case Declaration declaration:
                        {
                            declaration.Index = varIndex++;
                            break;
                        }
                        case IfStatement ifStatement:
                        {
                            if (ifStatement.TrueCaseBlockStatement is BlockStatement trueBlock)
                                SetBlockVarsIndexes(trueBlock, ref varIndex);
                            if (ifStatement.FasleCaseBlockStatement is BlockStatement falseBlock)
                                SetBlockVarsIndexes(falseBlock, ref varIndex);
                            break;
                        }
                        case WhileStatement whileStatement:
                        {
                            if (whileStatement.BlockOrSingleStatement is BlockStatement block)
                                SetBlockVarsIndexes(block, ref varIndex);
                            break;
                        }
                    }
            }
        }

        #endregion
    }
}