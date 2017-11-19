using System;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public abstract class Declaration: IStatement
    {
        private IExpression _value;

        public INode Parent { get; }
        public Scope Scope { get; }
        public bool IsConstructed { get; private set; }

        public string Name { get; protected set; }
        public ReturnType ReturnType { get; protected set; }

        public IExpression Value {
            get { return _value; }
            set {
                _value = value;
                Initialized = true;
            }
        }

        //This may be useful for semantics
        public bool Initialized { get; protected set; }

        protected Declaration(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }

        public virtual void Construct(CommonTree syntaxVariableDeclaration)
        {
            IsConstructed = true;
        }
    }
}