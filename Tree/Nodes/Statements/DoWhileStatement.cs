using System;
using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Statements
{
    public class DoWhileStatement: IStatement
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public DoWhileStatement(INode parent)
        {
            Parent = parent;
        }

        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }

    }
}