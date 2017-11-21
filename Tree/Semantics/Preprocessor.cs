using System;
using System.Security.Cryptography;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using MathLang.Tree.Scopes.Exceptions;
using Microsoft.Win32.SafeHandles;

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
                .ForEach(parameter => functionDeclaration.Scope.AddVariable(parameter));
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
            classDeclaration.VarDeclarationNodes.ForEach(Process);
        }

        private static void Process(this Declaration declaration)
        {
            switch (declaration)
            {
                case VariableDeclaration variableDeclaration:
                    variableDeclaration.Process();
                    break;
                case ArrayDeclaration arrayDeclaration:
                    arrayDeclaration.Process();
                    break;
            }
        }

        private static void Process(this ArrayDeclaration arrayDeclaration)
        {
            //            throw  new NotImplementedException();
        }

        private static void Process(this VariableDeclaration variableDeclaration)
        {
            //Process assignment value
            IExpression variableDeclarationValueExpression = variableDeclaration.Value;
            if (variableDeclarationValueExpression == null) return;
            variableDeclarationValueExpression.Process();
            if (variableDeclaration.ReturnType == variableDeclarationValueExpression.ReturnType) return;
            if (!variableDeclarationValueExpression.ReturnType.IsCastableTo(variableDeclaration.ReturnType))
            {
                throw new ScopeException(
                    $"Variable \"{variableDeclaration.Name}\" return type {variableDeclaration.ReturnType} is different from {variableDeclarationValueExpression.ReturnType} ");
            }
            var castExpression = new CastExpression(parentNode: variableDeclarationValueExpression.Parent,
                parentScope: variableDeclarationValueExpression.Scope,
                targetReturnType: variableDeclaration.ReturnType,
                value: variableDeclarationValueExpression);
        }

        private static void Process(this FunctionDeclaration functionDeclaration)
        {
            var scope = functionDeclaration.Scope;
            functionDeclaration.StatemenBlock.Statements
                .ForEach(statement => statement.Process());
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
            if (expression.Right == null)
            {
                if (expression.ReturnType == expression.Left.ReturnType) return;
                if (expression.Left.ReturnType.IsCastableTo(expression.ReturnType))
                {
                    var castExpression = new CastExpression(parentNode: expression,
                        parentScope: expression.Scope,
                        targetReturnType: expression.ReturnType,
                        value: expression.Left);
                    expression.Left.Parent = castExpression;
                }
                else
                    throw new ExpressionException(
                        $"Return type {expression.Left.ReturnType} does not match {expression.ReturnType}");
            }
            else if (expression.Left.ReturnType != expression.Right.ReturnType)
            {
                if (expression.Right.ReturnType.IsCastableTo(expression.Left.ReturnType))
                {
                    var castExpression = new CastExpression(parentNode: expression,
                        parentScope: expression.Scope,
                        targetReturnType: expression.Left.ReturnType,
                        value: expression.Right);
                }
                else
                    throw new ExpressionException(
                        $"Can not compare {expression.Left.ReturnType} tot {expression.Right.ReturnType}");
            }
        }

        private static void Process(this Atom atom)
        {
            //Nothing to do now
            //throw new InvalidOperationException("atom");
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
                default: throw new NotImplementedException();
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
                    var castExpression = new CastExpression(parentNode: assignmentValue.Parent,
                        parentScope: assignmentValue.Scope, 
                        targetReturnType: variableReturnType,
                        value: assignmentValue);
                    assignmentValue.Parent = castExpression;
                }
                else
                    throw new ScopeException(
                        $"Return type {assignmentValue.ReturnType} does not match {variableReturnType}");
            }
        }

        #endregion

        #endregion
    }
}