using System;
using System.Diagnostics;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Statements
{
    public class ReturnStatement : IStatement
    {
        public INode Parent { get; }
        public Scope Scope { get; }

        public IExpression ReturnExpression { get; private set; }

        public ReturnStatement(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, false);
        }
        
        public void Construct(CommonTree syntaxReturnStatement)
        {
            if (syntaxReturnStatement.ChildCount > 0)
            {
                var syntaxReturnExpression = syntaxReturnStatement.GetChild(0).CastTo<CommonTree>();
                ReturnExpression = TreeHelper.GetExpression(this, Scope, syntaxReturnExpression);
                ReturnExpression.Construct(syntaxReturnExpression);
            }

        }
    }
}