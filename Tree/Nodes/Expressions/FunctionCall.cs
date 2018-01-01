using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class FunctionCall : IExpression, IStatement
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }
        
        public ExtendedId ExtendedId { get; private set; }
        public TypeDefinition TypeDefinition { get; set; }
        public TypeDefinition CastToType { get; set; }
        public List<IExpression> FunctionCallParameters { get; } = new List<IExpression>();
        public FunctionDeclaration FunctionDeclaration => Scope.GlobalFunctionSearch(ExtendedId.Name);

        public FunctionCall(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }

        public void Construct(CommonTree syntaxFuncCallExpression)
        {
			TypeDefinition = TypeDefinition.Unset;            var syntaxExtendedId = syntaxFuncCallExpression.GetChild(0).CastTo<CommonTree>();
            ExtendedId = TreeHelper.GetExpression(this, Scope, syntaxExtendedId).CastTo<ExtendedId>();
            ExtendedId.Construct(syntaxExtendedId);
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