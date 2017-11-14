using Antlr.Runtime.Tree;

namespace MathLang.Tree.Nodes
{
    public interface INode
    {
        INode Parent { get; }

        void Construct(CommonTree tree);
    }
}