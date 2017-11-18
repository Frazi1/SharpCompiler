using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Statements
{
    public class WhileStatement : IStatement
    {
        public INode Parent { get; }
        public IExpression ConditionExpression { get; private set; }
        public IStatement BlockOrSingleStatement { get; private set; }
        public Scope Scope { get; }

        public WhileStatement(INode parent, Scope parentScope)
        {
            Parent = parent;
            this.Scope = new LocalScope(parentScope, false);
        }

        public void Construct(CommonTree syntaxWhile)
        {
            //condition
            var syntaxCondition = syntaxWhile.GetChild(0).CastTo<CommonTree>();
            ConditionExpression = TreeHelper.GetExpression(this, Scope, syntaxCondition);
            ConditionExpression.Construct(syntaxCondition);

            //var syntaxTrueStatementsBlock = syntaxWhile.GetChild(1).CastTo<CommonTree>();
            if (syntaxWhile.ChildCount > 1)
            {
                var syntaxBlockOrSingleStatement = syntaxWhile.GetChild(1).CastTo<CommonTree>();

                if (syntaxBlockOrSingleStatement.Type == MathLangParser.MULT_ARRAY_DECL)
                    
                    throw new InvalidOperationException("Single declarations are not supported");

                
                BlockOrSingleStatement =
                    TreeHelper.GetStatements(this, Scope, syntaxBlockOrSingleStatement)[0];
                BlockOrSingleStatement.Construct(syntaxBlockOrSingleStatement);
            }
        }
    }
}