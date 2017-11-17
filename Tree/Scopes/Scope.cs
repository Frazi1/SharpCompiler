using System.Collections.Generic;
using Antlr.Runtime.Misc;
using MathLang.Tree.Nodes.Declarations;

namespace MathLang.Tree.Scopes
{
    public abstract class Scope
    {
        protected Scope ParentScope { get; }
        protected List<VariableDeclaration> VariableDeclarations { get; }
        protected List<FunctionDeclaration> FunctionDeclarations { get; }
        protected List<ClassDeclaration> ClassDeclarations { get; }

        protected Scope(Scope parentScope)
        {
            ParentScope = parentScope;
            VariableDeclarations = new List<VariableDeclaration>();
            FunctionDeclarations = new ListStack<FunctionDeclaration>();
            ClassDeclarations = new List<ClassDeclaration>();
        }

        public abstract VariableDeclaration FindVariable(string name);
        public abstract FunctionDeclaration FindFunction(string name);
        public abstract ClassDeclaration FindClass(string name);

        public void AddVariable(VariableDeclaration variableDeclaration)
        {
            VariableDeclarations.Add(variableDeclaration);
        }

        public void AddFunction(FunctionDeclaration functionDeclaration)
        {
            FunctionDeclarations.Add(functionDeclaration);
        }

        public void AddClass(ClassDeclaration classDeclaration)
        {
            ClassDeclarations.Add(classDeclaration);
        }
        
    }
}