using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;

namespace MathLang.Tree.Nodes
{
    public class FunctionCallExpression : IExpression
    {
        public INode Parent { get; }

        public string Name { get; set; }
        public List<IExpression> Paremeters { get; } = new List<IExpression>();

        public FunctionCallExpression(INode parent)
        {
            Parent = parent;
        }

        public void Construct(CommonTree syntaxFuncCallExpression)
        {
            var nameNode = syntaxFuncCallExpression.GetChild(0).CastTo<CommonTree>();
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
                    IExpression parameter = TreeHelper.GetExpression(this, syntaxFuncCallExpression);
                    parameter.Construct(syntaxFuncCallExpression);
                });
        }
    }
}