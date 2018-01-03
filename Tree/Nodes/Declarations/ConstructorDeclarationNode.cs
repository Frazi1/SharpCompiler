using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class ConstructorDeclarationNode : INode
    {
        public INode Parent => DeclaringType;
        public Scope Scope { get; }

        public ClassDeclaration DeclaringType { get; }
        public Modifier Modifier { get; private set; }
        public ExtendedId ExtendedId { get; private set; }
        public List<FunctionVariableDeclarationParameter> Parameters { get; } = new List<FunctionVariableDeclarationParameter>();
        public BlockStatement BlockStatement { get; private set; }

        public ConstructorDeclarationNode(ClassDeclaration type, Scope scope)
        {
            DeclaringType = type;
            Scope = scope;
        }

        public void Construct(CommonTree syntaxConstructor)
        {
            //Modifier
            Modifier = TreeHelper.GetModifiersFromSyntaxModifiersNode(
                syntaxConstructor.GetChild(0).CastTo<CommonTree>());
            //ExtendedId
            ExtendedId = new ExtendedId(this, Scope);
            ExtendedId.Construct(syntaxConstructor.GetChild(1).CastTo<CommonTree>());

            //Parameters
            var syntaxParameters = syntaxConstructor.GetChild(2).CastTo<CommonTree>();
            if (syntaxParameters.ChildCount > 0)
            {
                syntaxParameters.Children.Cast<CommonTree>()
                    .ForEach(syntaxParameter =>
                    {
                        FunctionVariableDeclarationParameter parameter = new FunctionVariableDeclarationParameter(this, Scope);
                        parameter.Construct(syntaxParameter);
                        Parameters.Add(parameter);
                    });
            }
            //Block
            var syntaxBlock = syntaxConstructor.GetChild(3).CastTo<CommonTree>();
            BlockStatement = new BlockStatement(this, Scope, false);
            BlockStatement.Construct(syntaxBlock);
        }

        public ConstructorDeclarationNode GetDefaultConstructor(ClassDeclaration classDeclaration, Scope scope) =>
            new ConstructorDeclarationNode(classDeclaration, scope);
    }
}