using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class CharExpression : Atom
    {
        public CharExpression(INode parent, Scope parentScope) 
            : base(parent, parentScope)
        {
        }

        public override void Construct(CommonTree syntaxCharExpression)
        {
            ReturnType = ReturnType.Char;
            base.Construct(syntaxCharExpression);
        }
    }
}