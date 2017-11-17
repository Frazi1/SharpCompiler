using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes;

namespace MathLang.Tree
{
    public class Expression : IExpression
    {
        public INode Parent { get; }
        public Scope Scope { get;}

        public ExpressionType ExpressionType { get; set; }
        public IExpression Left { get; set; }
        public IExpression Right { get; set; }

        public Expression(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, false);
        }

        public void Construct(CommonTree syntaxExpressionNode)
        {
            ExpressionType = TreeHelper.GetExpressionType(syntaxExpressionNode.Type);
            var syntaxLeft = syntaxExpressionNode.GetChild(0).CastTo<CommonTree>();
            Left = TreeHelper.GetExpression(this, Scope, syntaxLeft);
            Left.Construct(syntaxLeft);
            if (syntaxExpressionNode.Children.Count > 1)
            {
                var syntaxRight = syntaxExpressionNode.GetChild(1).CastTo<CommonTree>();
                Right = TreeHelper.GetExpression(this, Scope, syntaxRight);
                Right.Construct(syntaxRight);
            }
        }
    }
}