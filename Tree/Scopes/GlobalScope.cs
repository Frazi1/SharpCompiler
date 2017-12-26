using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Scopes.Exceptions;

namespace MathLang.Tree.Scopes
{
    public class GlobalScope : Scope
    {
        public GlobalScope() 
            : base(null)
        {
        }

        public override ClassDeclaration GlobalClassSearch(string name)
        {
            return LocalClassSearch(name);
        }

        public override FunctionDeclaration GlobalFunctionSearch(string name)
        {
            var splitName = SplitName(name);
            if (splitName.Length < 2)
            {
                //throw new ScopeException("Herniu delaete, gospodin");
                return null;
            }
            string className = splitName[0];
            string functionName = splitName[1];
            return LocalClassSearch(className)?.Scope.LocalFunctionSearch(functionName);

        }

        public override VariableDeclaration GlobalVariableSearch(string name)
        {
            var splitName = SplitName(name);
            if (splitName.Length < 2)
            {
                //throw new ScopeException("Herniu delaete, gospodin");
                return null;
            }
            string className = splitName[0];
            string variableName = splitName[1];
            return LocalClassSearch(className)?.Scope.LocalVariableSearch(variableName);
        }

        private static string[] SplitName(string name) => name.Split('.');
    }
}