using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Statements
{
    public class IfStatement : IStatement
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public IExpression ConditionExpression { get; private set; }
        public IStatement TrueCaseBlockStatement { get; private set; }
        public IStatement FasleCaseBlockStatement { get; private set; }
        
        public IfStatement(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
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
            TrueCaseBlockStatement = TreeHelper.GetStatements(this, Scope, syntaxTrueStatementsBlock)
                .First();
            TrueCaseBlockStatement.Construct(syntaxTrueStatementsBlock);


            //False
            if(syntaxIf.ChildCount < 3)
                return;
            var syntaxFalseStatementsBlock = syntaxIf.GetChild(2).CastTo<CommonTree>();
            FasleCaseBlockStatement = TreeHelper.GetStatements(this, Scope, syntaxFalseStatementsBlock)
                .First();
            FasleCaseBlockStatement.Construct(syntaxFalseStatementsBlock);

        }
    }
}