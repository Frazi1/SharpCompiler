using Antlr.Runtime.Tree;
using MathLang.Extensions;

namespace MathLang.Tree.Nodes
{
    public class VariableDeclaration : INode
    {
        public INode Parent { get; }

        public string Name { get; set; }
        public ReturnType ReturnType { get; }
        public IExpression Value { get; set; }

        public VariableDeclaration(INode parent, ReturnType returnType)
        {
            Parent = parent;
            ReturnType = returnType;
        }

        public void Construct(CommonTree syntaxVariableDeclaration)
        {
            Name = syntaxVariableDeclaration.GetChild(0).Text;
            var syntaxValueExpression = syntaxVariableDeclaration.GetChild(1).CastTo<CommonTree>();
            Value = TreeHelper.GetExpression(this, syntaxValueExpression);
            Value.Construct(syntaxValueExpression);
        }
    }
}