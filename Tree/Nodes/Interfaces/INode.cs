using Antlr.Runtime.Tree;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Interfaces
{
    public interface INode
    {
        INode Parent { get; set; }

        Scope Scope { get; }
        //bool IsConstructed { get; }
        
        void Construct(CommonTree tree);
    }
}