using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Expressions
{
    public class ExtendedId : IExpression, IStatement
    {
        public INode Parent { get; }
        public Scope Scope { get; }

        public List<string> IdList { get; } = new List<string>();
        public string GetFullPath => string.Join(".", IdList);
        public ReturnType ReturnType { get; private set; }

        public ExtendedId(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, false);
        }

        public void Construct(CommonTree syntaxExtendedId)
        {
            syntaxExtendedId.Children.Cast<CommonTree>()
                .ForEach(id => IdList.Add(id.Text));
            ReturnType = ReturnType.Unset;
        }

        public override string ToString()
        {
            return GetFullPath;
        }
    }

}