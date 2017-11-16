using Antlr.Runtime.Tree;
using MathLang.Extensions;

namespace MathLang.Tree.Nodes
{
    public class VariableDeclaration : IStatement
    {
        public INode Parent { get; }
        public Scope Scope { get; }
        
        public string Name { get; set; }
        public ReturnType ReturnType { get; }
        public IExpression Value { get; set; }

        //This may be useful for semantics
        public bool Initialized { get; private set; }
        
        public VariableDeclaration(INode parent, Scope parentScope, ReturnType returnType)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, false);
            ReturnType = returnType;
        }

        public virtual void Construct(CommonTree syntaxVariableDeclaration)
        {
            Name = syntaxVariableDeclaration.GetChild(0).Text;
            //Check if we have a value assigned to the variable
            if (syntaxVariableDeclaration.ChildCount > 1)
            {
                var syntaxValueExpression = syntaxVariableDeclaration.GetChild(1).CastTo<CommonTree>();
                Value = TreeHelper.GetExpression(this, syntaxValueExpression);
                Value.Construct(syntaxValueExpression);
                Initialized = true;
            }
        }
    }
}