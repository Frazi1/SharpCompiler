using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes;
using MathLang.Tree.Nodes.Interfaces;

namespace MathLang.Tree.Nodes.Statements
{
    public class ForStatement : IStatement
    {
        public INode Parent { get; }

        public ForStatement(INode parent)
        {
            Parent = parent;
        }
        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }
}