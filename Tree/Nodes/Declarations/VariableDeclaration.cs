using System;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class VariableDeclaration: IStatement
    {
        private IExpression _value;

        public INode Parent { get; set; }
        public Scope Scope { get; }
        public bool IsConstructed { get; private set; }

        public string Name { get; set; }
        public ReturnType ReturnType { get; set; }

        public int? Index { get; set; }
        public bool IsStatic => Index == null;

        public IExpression Value {
            get { return _value; }
            set {
                _value = value;
                Initialized = true;
            }
        }

        //This may be useful for semantics
        public bool Initialized { get; protected set; }

        public VariableDeclaration(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }

        public virtual void Construct(CommonTree syntaxVariableDeclaration)
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
            IsConstructed = true;
        }
    }
}