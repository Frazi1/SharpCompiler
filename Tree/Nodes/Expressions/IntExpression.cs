using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class IntExpression : Atom
    {
        public new int Value { get; private set; }
        public IntExpression(INode parent, Scope parentScope)
            : base(parent, parentScope)
        {
        }

        public override void Construct(CommonTree node)
        {
            ReturnType = ReturnType.Int;
            Value = int.Parse(node.Text);
        }
    }
}