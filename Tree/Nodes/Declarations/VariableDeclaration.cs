using System;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class VariableDeclaration : Declaration
    {
        //This may be useful for semantics

        public VariableDeclaration(INode parent, Scope parentScope)
            : base(parent, parentScope)
        {
        }

        public override void Construct(CommonTree syntaxVariableDeclaration)
        {
            if (IsConstructed) throw new InvalidOperationException("Variable already constructed-");
            var syntaxReturnType = syntaxVariableDeclaration.GetChild(0).CastTo<CommonTree>();
            ReturnType = TreeHelper.GetReturnType(TreeHelper.GetStringTypeFromSyntaxNode(syntaxReturnType));
            Name = syntaxVariableDeclaration.GetChild(1).Text;
            //Check if we have a value assigned to the variable
            if (syntaxVariableDeclaration.ChildCount > 2)
            {
                var syntaxValueExpression = syntaxVariableDeclaration.GetChild(2).CastTo<CommonTree>();
                Value = TreeHelper.GetExpression(this, Scope, syntaxValueExpression);
                Value.Construct(syntaxValueExpression);
            }
            base.Construct(syntaxVariableDeclaration);
        }
    }
}