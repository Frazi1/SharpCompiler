using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes;

namespace MathLang.Tree
{
    public class IfStatement : IStatement
    {
        public INode Parent { get; }
        public Scope Scope { get; }
        
        public IfStatement(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, true);
        }

        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }
}