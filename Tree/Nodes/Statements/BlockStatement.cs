using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Statements
{
    public class BlockStatement: IStatement
    {
        public INode Parent { get; }
        public Scope Scope { get; }

        public List<IStatement> Statements { get; } = new List<IStatement>();
        
        public BlockStatement(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope);
        }
        
        public void Construct(CommonTree syntaxBlock)
        {
            if (syntaxBlock.ChildCount == 0)
                return;
            syntaxBlock.Children.Cast<CommonTree>()
                .ForEach(syntaxStatement =>
                {
                    var statements = TreeHelper.GetStatements(this, Scope, syntaxStatement);
                    statements.ForEach(statement =>
                    {
                        statement.Construct(syntaxStatement);
                    });
                    Statements.AddRange(statements);
                    
                    //Find all variable declarations and add them to scope
//                    statements.FindAll(statement => statement is VariableDeclaration)
//                        .Cast<VariableDeclaration>()
//                        .ForEach(variable => Scope.AddVariable(variable));
                });
        }
    }
}