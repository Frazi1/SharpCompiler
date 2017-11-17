using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Interfaces;

namespace MathLang.Tree.Nodes.Statements
{
    public class ArrayElementAssignmentStatement : IStatement
    {
        public INode Parent { get; }

        public ArrayElementAssignmentStatement(INode parent)
        {
            Parent = parent;
        }
        
        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }
}