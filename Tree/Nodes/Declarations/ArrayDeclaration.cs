using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class ArrayDeclaration: Declaration
    {
        public ArrayDeclaration(INode parent, Scope parentScope) 
            : base(parent, parentScope)
        {
        }

        public override void Construct(CommonTree syntaxArrayDeclaration)
        {
            string strType = string.Empty;
            var syntaxReturnType = syntaxArrayDeclaration.GetChild(0).CastTo<CommonTree>();
            syntaxReturnType.Children.ForEach(node => strType += node.Text);
            //ReturnType arrayElementsSimpleType = TreeHelper.GetReturnType(syntaxReturnType.GetChild(0).Text);
            //ReturnType = ReturnType.ArrayOf(arrayElementsSimpleType);

            ReturnType = TreeHelper.GetReturnType(strType);
            Name = syntaxArrayDeclaration.GetChild(1).Text;

            if(syntaxArrayDeclaration.ChildCount < 3) return;
            var syntaxArrayInitializerExpression = syntaxArrayDeclaration.GetChild(2).CastTo<CommonTree>();
            Value = TreeHelper.GetExpression(this, Scope, syntaxArrayInitializerExpression);
            Value.Construct(syntaxArrayInitializerExpression);
            base.Construct(syntaxArrayDeclaration);
        }
    }
}