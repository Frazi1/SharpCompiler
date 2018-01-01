using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class StringExpression : Atom
    {
        public StringExpression(INode parent, Scope parentScope) 
            : base(parent, parentScope)
        {
        }

        public override void Construct(CommonTree node)
        {
            TypeDefinition = Enums.TypeDefinition.String;
            base.Construct(node);
        }
    }
}