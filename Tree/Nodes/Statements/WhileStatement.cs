using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Statements
{
    public class WhileStatement : IStatement
    {
        public INode Parent { get; set; }
        public IExpression ConditionExpression { get; private set; }
        public IStatement BlockOrSingleStatement { get; private set; }
        public Scope Scope { get; }

        public WhileStatement(INode parent, Scope parentScope)
        {
            Parent = parent;
            this.Scope = parentScope;
        }

        public void Construct(CommonTree syntaxWhile)
        {
            //condition
            var syntaxCondition = syntaxWhile.GetChild(0).CastTo<CommonTree>();
            ConditionExpression = TreeHelper.GetExpression(this, Scope, syntaxCondition);
            ConditionExpression.Construct(syntaxCondition);

            if (syntaxWhile.ChildCount > 1)
            {
                var syntaxBlockOrSingleStatement = syntaxWhile.GetChild(1).CastTo<CommonTree>();
               
                BlockOrSingleStatement =
                    TreeHelper.GetStatements(this, Scope, syntaxBlockOrSingleStatement)[0];
                BlockOrSingleStatement.Construct(syntaxBlockOrSingleStatement);
            }
        }
    }
}