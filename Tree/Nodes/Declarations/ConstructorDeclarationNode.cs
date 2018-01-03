using System.Collections.Generic;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class ConstructorDefinition : INode
    {
        public INode Parent => DeclaringType;
        public Scope Scope { get; }

        public ClassDeclaration DeclaringType { get; }
        public Modifier Modifier { get; private set; }
        public List<IExpression> Parameters { get; } = new List<IExpression>();
        public List<IStatement> Statements { get; } = new List<IStatement>();

        public ConstructorDefinition(ClassDeclaration type, Scope scope)
        {
            DeclaringType = type;
            Scope = scope;
        }

        public void Construct(CommonTree syntaxConstructor)
        {
            throw new System.NotImplementedException();
        }

        public ConstructorDefinition GetDefaultConstructor(ClassDeclaration classDeclaration, Scope scope) =>
            new ConstructorDefinition(classDeclaration, scope);
    }
}