using Antlr.Runtime.Tree;

namespace MathLang.Tree.Nodes
{
    public class Parameter : INode
    {
        public INode Parent { get; }

        public ReturnType ReturnType { get; }

        public Parameter(INode parent, ReturnType returnType)
        {
            ReturnType = returnType;
            Parent = parent;
        }

        public void Construct(CommonTree tree)
        {
            throw new System.NotImplementedException();
        }

    }
}