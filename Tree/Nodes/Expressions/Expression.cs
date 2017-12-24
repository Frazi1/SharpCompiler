using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class Expression : IExpression
    {
        public INode Parent { get; set; }
        public Scope Scope { get;}

        public ExpressionType ExpressionType { get; set; }
        public ReturnType ReturnType { get; set; }
        public ReturnType CastToType { get; set; }
        public IExpression Left { get; set; }
        public IExpression Right { get; set; }

        public Expression(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
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
            if (ExpressionType == ExpressionType.Sub && Right == null)
            {
                var zeroExpression = new IntExpression(Parent, Parent.Scope) {Value = 0};
                Right = Left;
                Left = zeroExpression;
            }
            ReturnType = ReturnType.Unset;
            //if (Right == null) ReturnType = Left.ReturnType;
            //else
            //    ReturnType = Left.ReturnType.Equals(Right.ReturnType) 
            //        ? Left.ReturnType 
            //        : ReturnType.Unset;
        }
    }
}