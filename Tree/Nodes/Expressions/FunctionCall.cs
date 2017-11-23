using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class FunctionCall : IExpression, IStatement
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }
        
        public ExtendedId Name { get; private set; }
        public ReturnType ReturnType { get; set; }
        public ReturnType CastToType { get; set; }
        public List<IExpression> FunctionCallParameters { get; } = new List<IExpression>();

        public FunctionCall(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }

        public void Construct(CommonTree syntaxFuncCallExpression)
        {
			ReturnType = ReturnType.Unset;            var syntaxExtendedId = syntaxFuncCallExpression.GetChild(0).CastTo<CommonTree>();
            Name = TreeHelper.GetExpression(this, Scope, syntaxExtendedId).CastTo<ExtendedId>();
            Name.Construct(syntaxExtendedId);
            if (syntaxFuncCallExpression.ChildCount > 1)
            {
                syntaxFuncCallExpression.GetChild(1).CastTo<CommonTree>()
                    .Children.Cast<CommonTree>()
                    .ForEach(syntaxfuncCallParam =>
                    {
                        IExpression parameter = TreeHelper.GetExpression(this, Scope, syntaxfuncCallParam);             
                        parameter.Construct(syntaxfuncCallParam);
                        FunctionCallParameters.Add(parameter);
                    });
            }
        }
    }
}