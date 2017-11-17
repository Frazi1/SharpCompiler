using Antlr.Runtime.Tree;

namespace MathLang.Tree.Nodes
{
    public class FunctionDeclarationParameter : VariableDeclaration
    {
        //public INode Parent { get; }

        //public string Name { get; private set; }
        //public ReturnType ReturnType { get; private set; }

        //public FunctionDeclarationParameter(INode parent)
        //{
        //    Parent = parent;
        //}

        public FunctionDeclarationParameter(INode parent, Scope parentScope, ReturnType returnType) 
            : base(parent, parentScope, returnType)
        {
            Initialized = true;
        }

        public override void Construct(CommonTree tree)
        {
            //ReturnType = TreeHelper.GetReturnType(tree.GetChild(0).Text);
            Name = tree.GetChild(1).Text;
            //Add to scope
        }
    }
}