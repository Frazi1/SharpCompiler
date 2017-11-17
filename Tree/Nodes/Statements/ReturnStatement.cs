using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes;
using MathLang.Tree.Nodes.Interfaces;

namespace MathLang.Tree.Nodes.Statements
{
    public class ReturnStatement : IStatement
    {
        public INode Parent { get; }

        public ReturnStatement(INode parent)
        {
            Parent = parent;
        }
        
        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }
}