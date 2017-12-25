﻿using Antlr.Runtime.Tree;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public abstract class Declaration: IStatement
    {
        private IExpression _value;

        public INode Parent { get; set; }
        public Scope Scope { get; }
        public bool IsConstructed { get; private set; }

        public string Name { get; set; }
        public ReturnType ReturnType { get; set; }

        public int? Index { get; set; }
        
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