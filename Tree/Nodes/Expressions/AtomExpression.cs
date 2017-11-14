using System;
using System.Linq;
using Antlr.Runtime.Tree;

namespace MathLang.Tree.Nodes
{
    public class AtomExpression : IExpression
    {
        public INode Parent { get; }

        public ReturnType Type { get; private set; }
        public string Value { get; set; }

        public AtomExpression(INode parent)
        {
            Parent = parent;
        }

        public void Construct(CommonTree node)
        {
            Value = node.Text;

            if (node.Type == MathLangParser.ID)
            {
                if (node.ChildCount > 0)
                {
                    Value += "." + node.GetChild(0).Text;
                }
            }
            switch (node.Type)
            {
                case MathLangParser.TRUE: Type = ReturnType.Bool; break;
                case MathLangParser.FALSE: Type = ReturnType.Bool; break;
                case MathLangParser.CHAR: Type = ReturnType.Char; break;
                case MathLangParser.NUMBER: Type = ReturnType.Int; break;
                //If we have a variable then we must look up its type in the scope (which we don't have at the moment)
                case MathLangParser.ID: Type = ReturnType.Unset; break;
                default: throw new ArgumentOutOfRangeException(nameof(node.Type));
            }
        }
    }
}