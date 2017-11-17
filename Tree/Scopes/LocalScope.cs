using MathLang.Tree.Nodes;

namespace MathLang.Tree
{
    public class LocalScope : Scope
    {
        protected bool IntroduceScope { get; }

        public LocalScope(Scope parentScope, bool introduceScope)
            : base(parentScope)
        {
            IntroduceScope = introduceScope;
        }

        public override VariableDeclaration FindVariable(string name)
        {
            if (IntroduceScope)
            {
                var variableDeclaration = VariableDeclarations.Find(declaration => declaration.Name == name);
                if (variableDeclaration != null)
                {
                    return variableDeclaration;
                }
            }
            if (ParentScope != null)
            {
                return ParentScope.FindVariable(name);
            }
            return null;
        }

        public override FunctionDeclaration FindFunction(string name)
        {
            if (IntroduceScope)
            {
                var functionDeclaration = FunctionDeclarations.Find(declaration => declaration.Name == name);
                if (functionDeclaration != null)
                {
                    return functionDeclaration;
                }
            }
            if (ParentScope != null)
            {
                return ParentScope.FindFunction(name);
            }
            return null;
        }

        public override ClassDeclaration FindClass(string name)
        {
            if (IntroduceScope)
            {
                var classDeclaration = ClassDeclarations.Find(declaration => declaration.Name == name);
                if (classDeclaration != null)
                {
                    return classDeclaration;
                }
            }
            if (ParentScope != null)
            {
                return ParentScope.FindClass(name);
            }
            return null;
        }
    }
}