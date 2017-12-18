using System.Collections.Generic;

namespace MathLang.Tree.Nodes.Declarations
{
    public class Attribute
    {
        public string Name { get; set; }
        public List<FunctionDeclarationParameter> ParameterNodes { get; } = new List<FunctionDeclarationParameter>();
    }
}