using MathLang.Tree.Nodes.Declarations;

namespace MathLang.Tree.Scopes
{
    public abstract class Scope
    {
        public const int ProgramLevel = 1;
        public const int ClassLevel = 2;
        public const int FunctionLevel = 3;
        
        protected Scope ParentScope { get; }

        protected Scope(Scope parentScope)
        {
            ParentScope = parentScope;
            ScopeLevel = parentScope == null ? 1 : ParentScope.ScopeLevel + 1;

        }

        protected readonly ScopeTable<ClassDeclaration> ClassDeclarations = new ScopeTable<ClassDeclaration>();
        protected readonly ScopeTable<FunctionDeclaration> FunctionDeclarations = new ScopeTable<FunctionDeclaration>();
        protected readonly ScopeTable<Declaration> VariableDeclarations = new ScopeTable<Declaration>();

        public int ScopeLevel { get; }

        public virtual void AddClass(ClassDeclaration classDeclaration) =>
            ClassDeclarations.Add(classDeclaration.Name, classDeclaration);

        public virtual void AddFunction(FunctionDeclaration functionDeclaration) =>
            FunctionDeclarations.Add(functionDeclaration.Name, functionDeclaration);

        public virtual void AddVariable(Declaration declaration) =>
            VariableDeclarations.Add(declaration.Name, declaration);

        public bool ContainsClass(string name) => ClassDeclarations.Contains(name);
        public bool ContainsFunction(string name) => FunctionDeclarations.Contains(name);
        public bool ContainsVariable(string name) => VariableDeclarations.Contains(name);

        public ClassDeclaration LocalClassSearch(string name) => ClassDeclarations.FindByKey(name);
        public FunctionDeclaration LocalFunctionSearch(string name) => FunctionDeclarations.FindByKey(name);
        public Declaration LocalVariableSearch(string name) => VariableDeclarations.FindByKey(name);

        public abstract ClassDeclaration GlobalClassSearch(string name);
        public abstract FunctionDeclaration GlobalFunctionSearch(string name);
        public abstract Declaration GlobalVariableSearch(string name);

        public Declaration GlobalVariableSearch(string name, int upToLevel)
        {
            if (ScopeLevel < upToLevel) return null;
            var result = LocalVariableSearch(name) 
                         ?? ParentScope.GlobalVariableSearch(name, upToLevel);
            return result;
        }
        
        public override string ToString()
        {
            return $@"{ClassDeclarations}
{VariableDeclarations}
{FunctionDeclarations}";
        }
    }
}