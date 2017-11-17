using Antlr.Runtime.Tree;

namespace MathLang.Tree.Nodes.Interfaces
{
    public interface INode
    {
        INode Parent { get; }
        //bool IsConstructed { get; }
        
        void Construct(CommonTree tree);
    }
}