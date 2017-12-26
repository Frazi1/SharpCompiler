using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes
{
    public class AttributeUsage : INode
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public ExtendedId Name { get; private set; }
        public List<IExpression> FunctionCallParameters { get; } = new List<IExpression>();

        public AttributeUsage(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }

        public void Construct(CommonTree syntaxAttributeUsage)
        {
            Name = new ExtendedId(this, Scope);
            var syntaxExtendedId = syntaxAttributeUsage.GetChild(0).CastTo<CommonTree>();
            Name.Construct(syntaxExtendedId);

            var syntaxParameters = syntaxAttributeUsage.GetChild(1).CastTo<CommonTree>();
            if (syntaxParameters.ChildCount > 0)
            {
                syntaxParameters.Children.Cast<CommonTree>().ForEach(syntaxParameter =>
                {
                    var parameter = TreeHelper.GetExpression(this, Scope, syntaxParameter);
                    parameter.Construct(syntaxParameter);
                    FunctionCallParameters.Add(parameter);
                });    
            }
        }
    }
}