using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class BoolExpression : Atom
    {
        public BoolExpression(INode parent, Scope parentScope)
            : base(parent, parentScope)
        {
        }

        public override void Construct(CommonTree syntaxBoolExpression)
        {
            ReturnType = ReturnType.Bool;
            base.Construct(syntaxBoolExpression);
        }
    }
}