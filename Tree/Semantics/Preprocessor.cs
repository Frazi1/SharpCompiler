using System;
using System.Security.Cryptography;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
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
                if (scope.ContainsClass(classDeclaration.Name))
                    throw new ScopeException($"Class with name: {classDeclaration.Name} already exists");
                scope.AddClass(classDeclaration);
                classDeclaration.PreProcess();
            });
        }

        private static void PreProcess(this ClassDeclaration classDeclaration)
        {
            var scope = classDeclaration.Scope;

            classDeclaration.FunctionDeclarationNodes
                .ForEach(declaration =>
                {
                    if (scope.ContainsFunction(declaration.Name))
                        throw new ScopeException($"Function with name: \"{declaration.Name}\" already exists");
                    scope.AddFunction(declaration);
                });

            classDeclaration.VarDeclarationNodes
                .ForEach(declaration =>
                {
                    if (scope.ContainsVariable(declaration.Name))
                        throw new ScopeException($"Variable with name: \"{declaration.Name}\" already exists");
                    scope.AddVariable(declaration);
                });
        }

        #endregion

        #region Process

        public static void Process(this Nodes.Program program)
        {
            program.ClassNodes.ForEach(Process);
        }

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

        private static void Process(this FunctionDeclaration functionDeclaration)
        {
            //TODO: Implement
            //throw new NotImplementedException();
        }

        #endregion
    }
}