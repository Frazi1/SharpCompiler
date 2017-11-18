using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
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

        public FunctionDeclarationParameter(INode parent, Scope parentScope) 
            : base(parent, parentScope)
        {
            Initialized = true;
        }

        //public override void Construct(CommonTree tree)
        //{
            //ReturnType = TreeHelper.GetReturnType(tree.GetChild(0).Text);
            //Name = tree.GetChild(1).Text;
            //Add to scope
        //}
    }
}