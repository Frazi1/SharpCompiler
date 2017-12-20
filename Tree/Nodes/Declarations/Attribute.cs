using System.Collections.Generic;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class Attribute : ClassDeclaration
    {
        public override bool IsAttribute => true;
        public List<FunctionDeclarationParameter> ParameterNodes { get; } = new List<FunctionDeclarationParameter>();

        public Attribute(INode parent, Scope parentScope, bool isPrintable = true) 
            : base(parent, parentScope, isPrintable)
        {
        }
    }
}