using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class Atom : IExpression, IStatement
    {
        public INode Parent { get; }
        public Scope Scope { get; }

        public ReturnType Type { get; private set; }
        public string Value { get; set; }

        public Atom(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, false);
        }

        public virtual void Construct(CommonTree node)
        {
            Value = node.Text;


            switch (node.Type)
            {                
                case MathLangParser.TRUE: Type = ReturnType.Bool; break;
                case MathLangParser.FALSE: Type = ReturnType.Bool; break;
                case MathLangParser.CHAR: Type = ReturnType.Char; break;
                case MathLangParser.NUMBER: Type = ReturnType.Int; break;
                //If we have a variable then we must look up its type in the scope (which we don't have at the moment)
                default: throw new ArgumentOutOfRangeException(nameof(node.Type));
            }
        }
    }
}