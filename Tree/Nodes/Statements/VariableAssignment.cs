using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;


namespace MathLang.Tree.Nodes.Statements
{
    public class VariableAssignment : IStatement
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }
        
        public ExtendedId VariableName { get; private set; }
        public IExpression AssignmentValue { get; private set; }
        
        public VariableAssignment(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }
        
        public void Construct(CommonTree tree)
        {
            var syntaxExtendedId = tree.GetChild(0).CastTo<CommonTree>();
            VariableName = TreeHelper.GetExpression(this, Scope, syntaxExtendedId).CastTo<ExtendedId>();
            VariableName.Construct(syntaxExtendedId);

            var assignmentSyntax = tree.GetChild(1).CastTo<CommonTree>();
            AssignmentValue = TreeHelper.GetExpression(this, Scope, assignmentSyntax);
            AssignmentValue.Construct(assignmentSyntax);
        }
    }
}