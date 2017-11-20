using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Statements
{
    public class ForStatement : IStatement
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public IStatement InitializationStatement{ get; private set; }
        public IStatement IterationStatement { get; private set; } 
        public IExpression ConditionExpression { get; private set; }
        public IStatement BlockOrSingleStatement { get; private set; }

        public ForStatement(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope);
        }
        public void Construct(CommonTree syntaxFor)
        {
            //Initialization
            var syntaxForInitialization = syntaxFor.GetChild(0).CastTo<CommonTree>();
            if (syntaxForInitialization.ChildCount > 0)
            {
                //TODO: IMPLEMENT / FIX THIS
                syntaxForInitialization.Children.Cast<CommonTree>()
                    .ForEach(syntaxVarDeclarationOrAssignment =>
                    {
                        InitializationStatement =
                            TreeHelper.GetStatements(this, Scope, syntaxVarDeclarationOrAssignment).First();
                        InitializationStatement.Construct(syntaxVarDeclarationOrAssignment);
                    });
            }

            //Condition
            var syntaxForCondition = syntaxFor.GetChild(1).CastTo<CommonTree>();
            if (syntaxForCondition.ChildCount > 0)
            {
                syntaxForCondition.Children.Cast<CommonTree>()
                    .ForEach(syntaxBoolExpression =>
                    {
                        ConditionExpression = TreeHelper.GetExpression(this, Scope, syntaxBoolExpression);
                        ConditionExpression.Construct(syntaxBoolExpression);
                    });
            }

            //Iteration
            var syntaxForIteration = syntaxFor.GetChild(2).CastTo<CommonTree>();
            if (syntaxForIteration.ChildCount > 0)
            {
                syntaxForIteration.Children.Cast<CommonTree>()
                    .ForEach(syntaxVarAssignment =>
                    {
                        IterationStatement =  TreeHelper.GetStatements(this, Scope, syntaxVarAssignment).First();
                        //if(iterationExpression is Varial)
                        IterationStatement.Construct(syntaxVarAssignment);
                    });
            }


            //Block
            if (syntaxFor.ChildCount > 3)
            {
                var syntaxForBlock = syntaxFor.GetChild(3).CastTo<CommonTree>();
                if (syntaxForBlock.ChildCount > 0)
                {
                    syntaxForBlock.Children.Cast<CommonTree>()
                        .ForEach(syntaxBlock =>
                        {
                            BlockOrSingleStatement = TreeHelper.GetStatements(this, Scope, syntaxBlock).First();
                            BlockOrSingleStatement.Construct(syntaxBlock);
                        });
                }
            }
        }
    }
}