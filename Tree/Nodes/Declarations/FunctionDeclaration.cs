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

        public string Name { get; private set; }
        public ReturnType ReturnType { get; private set; }
        public BlockStatement StatemenBlock { get; private set; }

        public List<FunctionDeclarationParameter> ParameterNodes { get; } = new List<FunctionDeclarationParameter>();

        public FunctionDeclaration(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope);
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
                            new FunctionDeclarationParameter(this, Scope);
                        ParameterNodes.Add(functionDeclarationParameter);
//                        Scope.AddVariable(functionDeclarationParameter);
                        functionDeclarationParameter.Construct(syntaxParameter);
                    });
            }

            //Statements
            var syntaxStatementBlock = syntaxFunctionDeclaration.GetChild(3).CastTo<CommonTree>();
            StatemenBlock = TreeHelper.GetStatements(this, Scope, syntaxStatementBlock)
                .First().CastTo<BlockStatement>();
            StatemenBlock.Construct(syntaxStatementBlock);
        }
    }
}