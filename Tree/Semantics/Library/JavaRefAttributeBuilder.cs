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

        public Attribute Build()
        {
            var attr = new Attribute(_program, _program.Scope, false);
            attr.ParameterNodes.Add(
                new FunctionDeclarationParameter(attr, attr.Scope)
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