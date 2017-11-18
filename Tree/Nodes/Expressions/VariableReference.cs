using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class VariableReference : Atom
    {
        public VariableDeclaration VariableDeclaration { get; private set; }

        public VariableReference(INode parent, Scope parentScope)
            :base(parent, parentScope)
        {
            
        }

        /// <inheritdoc />
        public override void Construct(CommonTree syntaxVariableReference)
        {
            Value = syntaxVariableReference.Text;
            if (syntaxVariableReference.ChildCount > 0)
            {
                Value += "." + syntaxVariableReference.GetChild(0).Text;
            }
        }
    }
}