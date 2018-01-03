using System;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class VariableDeclaration : IStatement
    {
        private IExpression _value;

        public INode Parent { get; set; }
        public Scope Scope { get; }

        public bool IsConstructed { get; protected set; }

        public string Name { get; set; }
        public string TypeName { get; private set; }
        public TypeDefinition TypeDefinition { get; set; }
        public Modifier Modifier { get; private set; }

        public bool IsField { get; protected set; }
        public int? Index { get; set; }
        public bool IsStatic => Modifier.HasFlag(Modifier.Static);
        public IExpression Value
        {
            get { return _value; }
            set
            {
                _value = value;
                Initialized = true;
            }
        }

        //This may be useful for semantics
        public bool Initialized { get; protected set; }

        public string FullName => IsField 
            ? $"{Parent.CastTo<ClassDeclaration>().Name}/{Name}" 
            : Name;

        public VariableDeclaration(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = parentScope;
        }

        public virtual void Construct(CommonTree syntaxVariableDeclaration)
        {
            Construct(syntaxVariableDeclaration, false);
        }
        public virtual void Construct(CommonTree syntaxVariableDeclaration, bool isField)
        {
            if (IsConstructed) throw new InvalidOperationException("Variable already constructed-");
            IsField = isField;
            var syntaxModifiers = syntaxVariableDeclaration.GetChild(0).CastTo<CommonTree>();
            Modifier = TreeHelper.GetModifiersFromSyntaxModifiersNode(syntaxModifiers);
            var syntaxReturnType = syntaxVariableDeclaration.GetChild(1).CastTo<CommonTree>();
            //TypeDefinition = TreeHelper.GetReturnType(TreeHelper.GetStringTypeFromSyntaxNode(syntaxReturnType), Scope);
            TypeName = TreeHelper.GetStringTypeFromSyntaxNode(syntaxReturnType);
            Name = syntaxVariableDeclaration.GetChild(2).Text;
            //Check if we have a value assigned to the variable
            if (syntaxVariableDeclaration.ChildCount > 3)
            {
                var syntaxValueExpression = syntaxVariableDeclaration.GetChild(3).CastTo<CommonTree>();
                Value = TreeHelper.GetExpression(this, Scope, syntaxValueExpression);
                Value.Construct(syntaxValueExpression);
            }
            IsConstructed = true;
        }
    }
}