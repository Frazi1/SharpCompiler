using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Interfaces;

namespace MathLang.Tree.Nodes.Statements
{
    public class WhileStatement : IStatement
    {
        public INode Parent { get; }

        public WhileStatement(INode parent)
        {
            Parent = parent;
        }

        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }
}