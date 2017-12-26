using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class VoidExpression : Atom
    {
        public VoidExpression(INode parent, Scope parentScope)
            : base(parent, parentScope)
        {
            ReturnType = ReturnType.Void;
        }
    }
}