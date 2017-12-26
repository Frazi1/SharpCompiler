using System;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class FunctionVariableDeclarationParameter : VariableDeclaration
    {
        public FunctionVariableDeclarationParameter(INode parent, Scope parentScope)
            : base(parent, parentScope)
        {
            Initialized = true;
        }
    }
}