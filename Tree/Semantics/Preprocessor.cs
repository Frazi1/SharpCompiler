using System;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes.Exceptions;

namespace MathLang.Tree.Semantics
{
    public static class Preprocessor
    {
        public static void Process(this Nodes.Program program)
        {
            var scope = program.Scope;
            program.ClassNodes.ForEach(classDeclaration =>
            {
                if (scope.ContainsClass(classDeclaration.Name))
                    throw new ScopeException($"Class with name: {classDeclaration.Name} already exists");
                scope.AddClass(classDeclaration);
                classDeclaration.Process();
            });
        }

        public static void Process(this ClassDeclaration classDeclaration)
        {
            var scope = classDeclaration.Scope;
            classDeclaration.FunctionDeclarationNodes
                .ForEach(declaration => scope.AddFunction(declaration));
            classDeclaration.VarDeclarationNodes
                .ForEach(declaration =>
                {
                    if (scope.ContainsVariable(declaration.Name))
                        throw new ScopeException($"Variable with name: {declaration.Name} already exists");
                    scope.AddVariable(declaration);
                    declaration.Process();
                });
        }

        public static void Process(this Declaration declaration)
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

        public static void Process(this ArrayDeclaration arrayDeclaration)
        {
//            throw  new NotImplementedException();
        }

        public static void Process(this VariableDeclaration variableDeclaration)
        {
            var scope = variableDeclaration.Scope;


            //Process assignment value
            var variableDeclarationValue = variableDeclaration.Value;
            if (variableDeclarationValue != null)
            {
                variableDeclarationValue.Process();
                if (variableDeclaration.ReturnType != variableDeclarationValue.ReturnType)
                    throw new ScopeException(
                        $"Variable {variableDeclaration.Name} return type {variableDeclaration.ReturnType} is different from {variableDeclarationValue.ReturnType} ");
            }
        }

        public static void Process(this IExpression iexpression)
        {
        }
    }
}