using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;

namespace MathLang.Tree.Nodes
{
    public class Expression : IExpression
    {
        public INode Parent { get; set; }

        public ExpressionType ExpressionType { get; set; }
        public IExpression Left { get; set; }
        public IExpression Right { get; set; }

        public void Run(CommonTree syntaxExpressionNode)
        {
            ExpressionType = TreeHelper.GetExpressionType(syntaxExpressionNode.Type);
            var syntaxLeft = syntaxExpressionNode.GetChild(0) as CommonTree;
            Left = TreeHelper.RunExpression(syntaxLeft);
            Left.Parent = this;
            Left.Run(syntaxLeft);
            if (syntaxExpressionNode.Children.Count > 1)
            {
                var syntaxRight = syntaxExpressionNode.GetChild(1) as CommonTree;
                Right = TreeHelper.RunExpression(syntaxRight);
                Right.Parent = this;
                Right.Run(syntaxRight);

            }
        }
    }

    public class FunctionCallExpression : IExpression
    {
        public INode Parent { get; set; }

        public string Name { get; set; }
        public List<IExpression> Paremeters { get; } = new List<IExpression>();

        public void Run(CommonTree syntaxFuncCallExpression)
        {
            var nameNode = syntaxFuncCallExpression.GetChild(0) as CommonTree;
            Name = nameNode.Text;
            if (nameNode.Children.Any())
            {
                Name += "." + nameNode.GetChild(0).Text;
            }

            syntaxFuncCallExpression.Children
                .Skip(1)
                .Cast<CommonTree>()
                .ForEach(syntaxfuncCallParam =>
                {
                    IExpression parameter = TreeHelper.RunExpression(syntaxFuncCallExpression);
                    parameter.Parent = this;
                    parameter.Run(syntaxFuncCallExpression);
                });
        }
    }

    public class AtomExpression : IExpression
    {
        public INode Parent { get; set; }

        public ReturnType Type { get; set; }

        public String Value { get; set; }

        public void Run(CommonTree node)
        {
            Value = node.Text;

            if (node.Type == MathLangParser.ID)
            {
                if (node.Children.Any())
                {
                    Value += "." + node.GetChild(0).Text;
                }
            }
            switch (node.Type)
            {
                case MathLangParser.TRUE: Type = ReturnType.Bool; break;
                case MathLangParser.FALSE: Type = ReturnType.Bool; break;
                case MathLangParser.CHAR: Type = ReturnType.Char; break;
                case MathLangParser.NUMBER: Type = ReturnType.Int; break;
                default: throw new ArgumentOutOfRangeException(nameof(node.Type));
            }
        }
    }
}