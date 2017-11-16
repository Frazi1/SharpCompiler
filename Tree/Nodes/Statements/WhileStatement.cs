using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes;

namespace MathLang.Tree
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