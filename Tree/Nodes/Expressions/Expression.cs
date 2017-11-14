using Antlr.Runtime.Tree;
using MathLang.Extensions;

namespace MathLang.Tree.Nodes
{
    public class Expression : IExpression
    {
        public INode Parent { get; }

        public ExpressionType ExpressionType { get; set; }
        public IExpression Left { get; set; }
        public IExpression Right { get; set; }

        public Expression(INode parent)
        {
            Parent = parent;
        }

        public void Construct(CommonTree syntaxExpressionNode)
        {
            ExpressionType = TreeHelper.GetExpressionType(syntaxExpressionNode.Type);
            var syntaxLeft = syntaxExpressionNode.GetChild(0).CastTo<CommonTree>();
            Left = TreeHelper.GetExpression(this, syntaxLeft);
            Left.Construct(syntaxLeft);
            if (syntaxExpressionNode.Children.Count > 1)
            {
                var syntaxRight = syntaxExpressionNode.GetChild(1).CastTo<CommonTree>();
                Right = TreeHelper.GetExpression(this, syntaxRight);
                Right.Construct(syntaxRight);
            }
        }
    }
}