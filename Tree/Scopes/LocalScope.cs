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

        public override Declaration FindVariable(string name)
        {
            var declaration = VariableDeclarations.FindByKey(name);
            return declaration ?? ParentScope?.FindVariable(name);
        }

        public override FunctionDeclaration FindFunction(string name)
        {
            var functionDeclaration = FunctionDeclarations.FindByKey(name);
            return functionDeclaration ?? ParentScope?.FindFunction(name);
        }

        public override ClassDeclaration FindClass(string name)
        {
            var classDeclaration = ClassDeclarations.FindByKey(name);
            return classDeclaration ?? ParentScope?.FindClass(name);
        }
    }
}