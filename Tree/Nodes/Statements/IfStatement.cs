using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes;

namespace MathLang.Tree
{
    public class IfStatement : IStatement
    {
        public INode Parent { get; }
        public Scope Scope { get; }

        public IExpression ConditionExpression { get; private set; }
        public List<IStatement> TrueCaseStatements { get; } = new List<IStatement>();
        public List<IStatement> FalseCaseStatements { get; } = new List<IStatement>();
        
        public IfStatement(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, false);
        }

        public void Construct(CommonTree syntaxIf)
        {
            //Condition
            var syntaxCondition = syntaxIf.GetChild(0).CastTo<CommonTree>();
            ConditionExpression = TreeHelper.GetExpression(this, Scope, syntaxCondition);
            ConditionExpression.Construct(syntaxCondition);

            //check if we have an empty block
            if(syntaxIf.ChildCount < 2) 
                return;
            
            //True
            var syntaxTrueStatementsBlock = syntaxIf.GetChild(1).CastTo<CommonTree>();
            if (syntaxTrueStatementsBlock.ChildCount > 0)
            {
                syntaxTrueStatementsBlock.Children.Cast<CommonTree>()
                    .ForEach(syntaxStatement =>
                    {
                        var statements = TreeHelper.GetStatements(this, Scope, syntaxStatement);
                    });
            }
            
            //False

        }
    }
}