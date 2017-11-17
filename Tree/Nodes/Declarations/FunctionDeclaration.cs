using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class FunctionDeclaration : INode
    {
        public INode Parent { get; }
        public Scope Scope { get; }

        public string Name { get; set; }
        public ReturnType ReturnType { get; set; }
        public List<FunctionDeclarationParameter> ParameterNodes { get; }
        public BlockStatement StatemenBlock { get; private set; }

        public FunctionDeclaration(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, true);
            ParameterNodes = new List<FunctionDeclarationParameter>();
            StatemenBlock = new BlockStatement(this, Scope);
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
                        FunctionDeclarationParameter functionDeclarationParameter =
                            new FunctionDeclarationParameter(this, Scope,
                                TreeHelper.GetReturnType(syntaxParameter.GetChild(0).Text));
                        ParameterNodes.Add(functionDeclarationParameter);
                        Scope.AddVariable(functionDeclarationParameter);
                        functionDeclarationParameter.Construct(syntaxParameter);
                    });
            }

            //Statements
            var syntaxStatementBlock = syntaxFunctionDeclaration.GetChild(3).CastTo<CommonTree>();
            StatemenBlock.Construct(syntaxStatementBlock);
            //    if (syntaxStatementBlock.ChildCount > 0)
            //    {
            //        syntaxStatementBlock.Children.Cast<CommonTree>()
            //            .ForEach(syntaxStatement =>
            //            {
            //                List<IStatement> statements = TreeHelper.GetStatements(this, Scope, syntaxStatement);
            //                StatementNodes.AddRange(statements);
            //                statements.ForEach(statement =>
            //                {
            //                    //if it is a variable we must not call Construct, because it was already constructed in TreeHelper
            //                    if (statement is VariableDeclaration variable)
            //                    {
            //                        Scope.AddVariable(variable);
            //                        return;
            //                    }
            //                    statement.Construct(syntaxStatement);
            //                });
            //            });
            //    }
        }
    }
}