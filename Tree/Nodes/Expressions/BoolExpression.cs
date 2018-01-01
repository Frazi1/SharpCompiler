using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class BoolExpression : Atom
    {
        public new bool Value { get; private set; } 
        public BoolExpression(INode parent, Scope parentScope)
            : base(parent, parentScope)
        {
        }

        public override void Construct(CommonTree syntaxBoolExpression)
        {
            TypeDefinition = Enums.TypeDefinition.Bool;
            Value = syntaxBoolExpression.Text == "true";
            //base.Construct(syntaxBoolExpression);
        }
    }
}