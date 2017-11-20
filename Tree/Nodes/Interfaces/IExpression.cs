using MathLang.Tree.Nodes.Enums;

namespace MathLang.Tree.Nodes.Interfaces
{
    public interface IExpression : INode
    {
        ReturnType ReturnType { get; }
    }
}