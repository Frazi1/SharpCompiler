using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public abstract class Atom : IExpression, IStatement
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public ReturnType ReturnType { get; set; }
        public ReturnType CastToType { get; set; }
        public virtual string Value { get; set; }

        protected Atom(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }

        public virtual void Construct(CommonTree node)
        {
            Value = node.Text;


            //switch (node.Type)
            //{                
            //    case MathLangParser.CHAR: ReturnType = ReturnType.Char; break;
            //    case MathLangParser.NUMBER: ReturnType = ReturnType.Int; break;
                
            //    //If we have a variable then we must look up its type in the scope (which we don't have at the moment)
            //    default: throw new ArgumentOutOfRangeException(nameof(node.Type));
            //}
        }
    }
}