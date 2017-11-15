using Antlr.Runtime.Tree;

namespace MathLang.Tree.Nodes
{
    public class FunctionDeclarationParameter : INode
    {
        public INode Parent { get; }

        public string Name { get; private set; }
        public ReturnType ReturnType { get; private set; }

        public FunctionDeclarationParameter(INode parent)
        {
            Parent = parent;
        }

        public void Construct(CommonTree tree)
        {
            ReturnType = TreeHelper.GetReturnType(tree.GetChild(0).Text);
            Name = tree.GetChild(1).Text;
            //Add to scope
        }
    }
}