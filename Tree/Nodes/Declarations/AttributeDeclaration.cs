using System.Collections.Generic;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class AttributeDeclaration : ClassDeclaration
    {
        public override bool IsAttribute => true;
        public List<FunctionVariableDeclarationParameter> ParameterNodes { get; } = new List<FunctionVariableDeclarationParameter>();

        public AttributeDeclaration(INode parent, Scope parentScope) 
            : base(parent, parentScope, false, false)
        {
        }
    }
}