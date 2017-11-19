using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Statements
{
    public class ArrayElementAssignment : IStatement
    {
        public INode Parent { get; }
        public Scope Scope { get; }

        public ArrayElementAssignment(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, false);
        }
        
        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }
}