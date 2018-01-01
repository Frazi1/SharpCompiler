using MathLang.Tree.Nodes.Enums;

namespace MathLang.Tree.Nodes.Interfaces
{
    public interface IExpression : INode
    {
        TypeDefinition TypeDefinition { get; set; }
        TypeDefinition CastToType { get; set; }
    }
}