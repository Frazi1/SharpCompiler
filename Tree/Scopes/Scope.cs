using System;
using System.Collections.Generic;
using Antlr.Runtime.Misc;
using MathLang.Tree.Nodes.Declarations;

namespace MathLang.Tree.Scopes
{
    public abstract class Scope
    {
        protected Scope ParentScope { get; }

        protected Scope(Scope parentScope)
        {
            ParentScope = parentScope;
        }

        protected readonly ScopeTable<ClassDeclaration> ClassDeclarations = new ScopeTable<ClassDeclaration>();
        protected readonly ScopeTable<FunctionDeclaration> FunctionDeclarations = new ScopeTable<FunctionDeclaration>();
        protected readonly ScopeTable<Declaration> VariableDeclarations = new ScopeTable<Declaration>();

        public virtual void AddClass(ClassDeclaration classDeclaration) =>
            ClassDeclarations.Add(classDeclaration.Name, classDeclaration);

        public virtual void AddFunction(FunctionDeclaration functionDeclaration) =>
            FunctionDeclarations.Add(functionDeclaration.Name, functionDeclaration);

        public virtual void AddVariable(Declaration declaration) =>
            VariableDeclarations.Add(declaration.Name, declaration);

        public bool ContainsClass(string name) => ClassDeclarations.Contains(name);
        public bool ContainsFunction(string name) => FunctionDeclarations.Contains(name);
        public bool ContainsVariable(string name) => VariableDeclarations.Contains(name);

        public abstract ClassDeclaration FindClass(string name);
        public abstract FunctionDeclaration FindFunction(string name);
        public abstract Declaration FindVariable(string name);

        public override string ToString()
        {
            return $@"{ClassDeclarations}
{VariableDeclarations}
{FunctionDeclarations}";
        }
    }
}