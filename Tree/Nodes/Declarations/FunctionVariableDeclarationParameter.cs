using System;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
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

        public override void Construct(CommonTree syntaxVariableDeclaration)
        {
            IsField = false;
            var syntaxReturnType = syntaxVariableDeclaration.GetChild(0).CastTo<CommonTree>();
            ReturnType = TreeHelper.GetReturnType(TreeHelper.GetStringTypeFromSyntaxNode(syntaxReturnType));
            Name = syntaxVariableDeclaration.GetChild(1).Text;
            IsConstructed = true;
        }
    }
}