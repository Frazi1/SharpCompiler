using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Scopes;
using MathLang.Tree.Scopes.Exceptions;

namespace MathLang.Tree.Semantics
{
    public static class SemanticsHelper
    {
        public static void CheckName(this VariableDeclaration variableDeclaration, Scope scopeToCheck)
        {
            if (scopeToCheck.ContainsVariable(variableDeclaration.Name))
                throw new ScopeException($"Variable with name: \"{variableDeclaration.Name}\" already exists");
        }

        public static void CheckName(this FunctionDeclaration functionDeclaration, Scope scopeToCheck)
        {
            if (scopeToCheck.ContainsFunction(functionDeclaration.Name))
                throw new ScopeException($"Function with name: \"{functionDeclaration.Name}\" already exists");
        }

        public static void CheckName(this ClassDeclaration classDeclaration, Scope scopeToCheck)
        {
            if (scopeToCheck.ContainsClass(classDeclaration.Name))
                throw new ScopeException($"Class with name: {classDeclaration.Name} already exists");
        }
    }
}