using System;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class ArrayElementReference: IExpression
    {
        public INode Parent { get; }
        public Scope Scope { get; }

        public ExtendedId Name { get; private set; }
        public IExpression ArrayIndex { get; private set; }
        public ReturnType ReturnType => Name.ReturnType;
        public ArrayDeclaration ArrayDeclaration { get; private set; }

        public ArrayElementReference(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, false);
        }


        public void Construct(CommonTree syntaxArrayElementReference)
        {
            var syntaxExtendedId =  syntaxArrayElementReference.GetChild(0).CastTo<CommonTree>();
            Name = TreeHelper.GetExpression(this, Scope, syntaxExtendedId).CastTo<ExtendedId>();
            Name.Construct(syntaxExtendedId);

            var syntaxArrayIndex = syntaxArrayElementReference.GetChild(1).CastTo<CommonTree>();
            ArrayIndex = TreeHelper.GetExpression(this, Scope, syntaxArrayIndex);
            ArrayIndex.Construct(syntaxArrayIndex);
        }

    }
}