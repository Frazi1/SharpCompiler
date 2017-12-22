using System.Collections.Specialized;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class VariableReference : IExpression
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public ReturnType CastToType { get; set; }
        public ReturnType ReturnType
        {
            get { return Name.ReturnType; }
            set { Name.ReturnType = value; }
        }


        public ExtendedId Name { get; private set; }
        public VariableDeclaration VariableDeclaration { get; set; }

        public VariableReference(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }
        
        public void Construct(CommonTree syntaxVariableReference)
        {
            var syntaxExtendedId = syntaxVariableReference.GetChild(0).CastTo<CommonTree>();
            Name = TreeHelper.GetExpression(this, Scope, syntaxExtendedId).CastTo<ExtendedId>();
            Name.Construct(syntaxExtendedId);
        }
    }
}