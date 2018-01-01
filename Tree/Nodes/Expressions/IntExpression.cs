using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class IntExpression : Atom
    {
        public new int Value { get; set; }
        public IntExpression(INode parent, Scope parentScope)
            : base(parent, parentScope)
        {
            TypeDefinition = Enums.TypeDefinition.Int;
        }

        public override void Construct(CommonTree node)
        {
            Value = int.Parse(node.Text);
        }
    }
}