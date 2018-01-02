using System.Collections.Generic;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class NewExpression : IExpression, IStatement
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public TypeDefinition TypeDefinition { get; set; }
        public TypeDefinition CastToType { get; set; }
        public List<IExpression> InitializationParameters { get; } = new List<IExpression>();

        public NewExpression(INode parent, Scope scope)
        {
            Parent = parent;
            Scope = scope;
        }   

        public void Construct(CommonTree tree)
        {
            var syntaxReturnType = tree.GetChild(0).CastTo<CommonTree>();
            TypeDefinition = TreeHelper.GetReturnType(TreeHelper.GetStringTypeFromSyntaxNode(syntaxReturnType));
        }
    }
}