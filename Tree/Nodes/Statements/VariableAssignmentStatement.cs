using System;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes;

namespace MathLang.Tree
{
    public class VariableAssignmentStatement : IStatement
    {
        public INode Parent { get; }
        public Scope Scope { get; }
        
        public string VariableName { get; private set; }
        public IStatement AssignmentValue { get; private set; }
        
        public VariableAssignmentStatement(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, false);
        }
        
        public void Construct(CommonTree tree)
        {
            VariableName = tree.GetChild(0).Text;
            var assignmentSyntax = tree.GetChild(1).CastTo<CommonTree>();
            AssignmentValue = TreeHelper.GetStatements(this, Scope, assignmentSyntax).First();
            AssignmentValue.Construct(assignmentSyntax);
        }
    }
}