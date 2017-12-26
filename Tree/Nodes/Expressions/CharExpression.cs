using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class CharExpression : Atom
    {
        public new int Value { get; private set; }
        public CharExpression(INode parent, Scope parentScope) 
            : base(parent, parentScope)
        {
        }

        public override void Construct(CommonTree syntaxCharExpression)
        {
            ReturnType = ReturnType.Char;
            char character = syntaxCharExpression.Text.RemoveFirstAndLastCharacters()[0];
            Value = character;
            //base.Construct(syntaxCharExpression);
        }
    }
}