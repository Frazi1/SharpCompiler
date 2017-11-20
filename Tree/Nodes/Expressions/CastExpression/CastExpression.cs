using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class CastExpression : IExpression
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }
        public ReturnType ReturnType { get; }
        public IExpression Value { get; }

        public CastExpression(INode parentNode, Scope parentScope, ReturnType targetReturnType, IExpression value)
        {
            Parent = parentNode;
            Scope = parentScope;
            ReturnType = targetReturnType;
            Value = value;
        }

        public void Construct(CommonTree tree)
        {
        }
    }
}