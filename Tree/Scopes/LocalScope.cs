using System;
using MathLang.Tree.Nodes.Declarations;

namespace MathLang.Tree.Scopes
{
    public class LocalScope : Scope
    {

        public LocalScope(Scope parentScope)
            : base(parentScope)
        {
        }
        
        public override VariableDeclaration GlobalVariableSearch(string name)
        {
            var declaration = VariableDeclarations.FindByKey(name);
            return declaration ?? ParentScope?.GlobalVariableSearch(name);
        }

        public override FunctionDeclaration GlobalFunctionSearch(string name)
        {
            var functionDeclaration = FunctionDeclarations.FindByKey(name);
            return functionDeclaration ?? ParentScope?.GlobalFunctionSearch(name);
        }

        public override ClassDeclaration GlobalClassSearch(string name)
        {
            var classDeclaration = ClassDeclarations.FindByKey(name);
            return classDeclaration ?? ParentScope?.GlobalClassSearch(name);
        }
    }
}