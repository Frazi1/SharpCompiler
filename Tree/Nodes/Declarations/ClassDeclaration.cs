using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class ClassDeclaration : INode
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public string Name { get; set; }
        public List<VariableDeclaration> VarDeclarationNodes { get; } = new List<VariableDeclaration>();
        public List<FunctionDeclaration> FunctionDeclarationNodes { get; } = new List<FunctionDeclaration>();
        public List<Modifier> ModifiersList { get; } = new List<Modifier>();
        public bool IsPrintable { get; }
        public bool CodeGeneration { get; }

        public virtual bool IsAttribute => false;
        public bool IsStatic => ModifiersList.Contains(Modifier.Static);
        public bool IsExtern => ModifiersList.Contains(Modifier.Extern);


        public ClassDeclaration(INode parent, Scope parentScope, bool isPrintable = true, bool codeGeneration = true)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope);
            IsPrintable = isPrintable;
            CodeGeneration = codeGeneration;
        }

        public void Construct(CommonTree syntaxClass)
        {
            Name = syntaxClass.Children[0].Text;
            var syntaxModifiers = syntaxClass.GetChild(1).CastTo<CommonTree>();
            if (syntaxModifiers.ChildCount > 0)
            {
                syntaxModifiers.Children.ForEach(mod =>
                {
                    if(mod.Text == Modifiers.Extern) ModifiersList.Add(Modifier.Extern);
                    else if(mod.Text == Modifiers.Static) ModifiersList.Add(Modifier.Static);
                    else throw new Exception($"Modifier {mod.Text} is not defined");
                });
            }
            var classblock = syntaxClass.GetChild(2).CastTo<CommonTree>();
            if(classblock.ChildCount == 0) return;
            classblock.Children
                .Cast<CommonTree>()
                .ForEach(child =>
                {
                    if (child.Type == MathLangParser.VARDECLARATION)
                    {
//                        child.Children.Cast<CommonTree>()
//                            .Select(syntaxVariableDeclaration =>
//                            {
                                var variableDeclaration = TreeHelper
                                    .GetStatements(this, Scope, child).First()
                                    .CastTo<VariableDeclaration>();
                                variableDeclaration.Construct(child, true);
                                VarDeclarationNodes.Add(variableDeclaration);
//                            })
//                            .ForEach(declaration => VarDeclarationNodes.Add(declaration));
                    }
                    else if (child.Type == MathLangParser.FUNCDECLARATION)
                    {
                        FunctionDeclaration function = new FunctionDeclaration(this, Scope);
                        FunctionDeclarationNodes.Add(function);
//                        Scope.AddFunction(function);
                        function.Construct(child);
                    }
                });
        }
    }
}