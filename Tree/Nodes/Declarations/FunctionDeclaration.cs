using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;

namespace MathLang.Tree.Nodes
{
    public class FunctionDeclaration : INode
    {
        public INode Parent { get; }

        public string Name { get; set; }
        public ReturnType ReturnType { get; set; }
        public List<FunctionDeclarationParameter> ParameterNodes { get; }
        public List<IStatement> StatementNodes { get; }

        public FunctionDeclaration(INode parent)
        {
            Parent = parent;
            ParameterNodes = new List<FunctionDeclarationParameter>();
            StatementNodes = new List<IStatement>();
        }

        public void Construct(CommonTree syntaxFunctionDeclaration)
        {
            Name = syntaxFunctionDeclaration.GetChild(0).Text;
            ReturnType = TreeHelper.GetReturnType(syntaxFunctionDeclaration.GetChild(1).GetChild(0).Text);
            //Parameters
            var syntaxParametersNode = syntaxFunctionDeclaration.GetChild(2).CastTo<CommonTree>();
            if (syntaxParametersNode.ChildCount > 0)
            {
                syntaxParametersNode.Children.Cast<CommonTree>()
                    .ForEach(syntaxParameter =>
                    {
                        FunctionDeclarationParameter functionDeclarationParameter = new FunctionDeclarationParameter(this);
                        ParameterNodes.Add(functionDeclarationParameter);
                        functionDeclarationParameter.Construct(syntaxParameter);
                    });
            }

            var syntaxStatementBlock = syntaxFunctionDeclaration.GetChild(3).CastTo<CommonTree>();
            if (syntaxStatementBlock.ChildCount > 0)
            {
                syntaxStatementBlock.Children.Cast<CommonTree>()
                    .ForEach(syntaxStatement =>
                    {
                        List<IStatement> statements = TreeHelper.GetStatements(this, syntaxStatement);
                        StatementNodes.AddRange(statements);
                        statements.ForEach(statement =>
                        {
                            //if it is a variable we must not call Construct, because it was already constructed in TreeHelper
                            if (statement is VariableDeclaration)
                                return;
                            statement.Construct(syntaxStatement);
                        });
                    } );
            }   
        }
    }
}