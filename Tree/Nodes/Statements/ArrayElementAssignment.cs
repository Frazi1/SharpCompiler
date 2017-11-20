using System;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Statements
{
    public class ArrayElementAssignment : IStatement
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public ArrayElementReference ArrayElementReference { get; private set; }
        public IExpression AssignmentExpression { get; private set; }

        public ArrayElementAssignment(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }
        
        public void Construct(CommonTree syntaxArrayElementAssignment)
        {
            //Array element reference
            var syntaxArrayElementReference = syntaxArrayElementAssignment.GetChild(0).CastTo<CommonTree>();
            ArrayElementReference = TreeHelper.GetExpression(this, Scope, syntaxArrayElementReference)
                .CastTo<ArrayElementReference>();
            ArrayElementReference.Construct(syntaxArrayElementReference);

            //Assignment Value
            var syntaxAssignmentExpression = syntaxArrayElementAssignment.GetChild(1).CastTo<CommonTree>();
            AssignmentExpression = TreeHelper.GetExpression(this, Scope, syntaxAssignmentExpression);
            AssignmentExpression.Construct(syntaxAssignmentExpression);
        }
    }
}