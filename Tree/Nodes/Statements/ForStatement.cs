using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes;

namespace MathLang.Tree
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