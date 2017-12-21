using System.Collections.Generic;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class AttributeDeclaration : ClassDeclaration
    {
        public override bool IsAttribute => true;
        public List<FunctionDeclarationParameter> ParameterNodes { get; } = new List<FunctionDeclarationParameter>();

        public AttributeDeclaration(INode parent, Scope parentScope) 
            : base(parent, parentScope, false, false)
        {
        }
    }
}