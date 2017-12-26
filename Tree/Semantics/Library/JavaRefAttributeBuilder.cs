using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;

namespace MathLang.Tree.Semantics
{
    public class JavaRefAttributeBuilder
    {
        private readonly Nodes.Program _program;

        public JavaRefAttributeBuilder(Nodes.Program program)
        {
            _program = program;
        }

        public AttributeDeclaration Build()
        {
            var attr = new AttributeDeclaration(_program, _program.Scope);
            attr.ParameterNodes.Add(
                new FunctionVariableDeclarationParameter(attr, attr.Scope)
                {
                    ReturnType = ReturnType.String,
                    Name = "ReferencePath",
                    Index = 0
                });
            attr.Name = "JavaRef";
            return attr;
        }
    }
}