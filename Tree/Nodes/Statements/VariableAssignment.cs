using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;


namespace MathLang.Tree.Nodes.Statements
{
    public class VariableAssignment : IStatement, IExpression
    {
        public INode Parent { get; }
        public Scope Scope { get; }
        
        public string VariableName { get; private set; }
        public IExpression AssignmentValue { get; private set; }
        
        public VariableAssignment(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, false);
        }
        
        public void Construct(CommonTree tree)
        {
            VariableName = tree.GetChild(0).Text;
            var assignmentSyntax = tree.GetChild(1).CastTo<CommonTree>();
            AssignmentValue = TreeHelper.GetExpression(this, Scope, assignmentSyntax);
            AssignmentValue.Construct(assignmentSyntax);
        }
    }
}