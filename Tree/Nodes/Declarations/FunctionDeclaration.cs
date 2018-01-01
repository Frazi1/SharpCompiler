using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes.Declarations
{
    public class FunctionDeclaration : INode
    {
        public INode Parent { get; set; }
        public Scope Scope { get; }

        public string Name { get; set; }
        public TypeDefinition TypeDefinition { get; set; }
        public BlockStatement StatementBlock { get; set; }

        public bool IsStatic { get; internal set; }
        public bool IsExternal { get; internal set; }

        public string FullName => $"{Parent.CastTo<ClassDeclaration>().Name}/{Name.ToCamelCase()}";
        public List<FunctionVariableDeclarationParameter> ParameterNodes { get; } = new List<FunctionVariableDeclarationParameter>();
        public List<Modifier> ModifiersList { get; } = new List<Modifier>();
        public List<AttributeUsage> AttributeUsages { get; } = new List<AttributeUsage>();
        
        public FunctionDeclaration(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope);
        }

        public void Construct(CommonTree syntaxFunctionDeclaration)
        {
            //Name
            Name = syntaxFunctionDeclaration.GetChild(0).Text;
            //Modifiers
            var syntaxModifiers = syntaxFunctionDeclaration.GetChild(1).CastTo<CommonTree>();
            if (syntaxModifiers.ChildCount > 0)
            {
                syntaxModifiers.Children.ForEach(mod =>
                {
                    if (mod.Text == Modifiers.Extern) ModifiersList.Add(Modifier.Extern);
                    else if (mod.Text == Modifiers.Static) ModifiersList.Add(Modifier.Static);
                    else throw new Exception($"Modifier {mod.Text} is not defined");
                });
            }
            //Attributes
            var syntaxAttributeUsages = syntaxFunctionDeclaration.GetChild(2).CastTo<CommonTree>();
            if (syntaxAttributeUsages.ChildCount > 0)
            {
                syntaxAttributeUsages.Children.Cast<CommonTree>().ForEach(syntaxAttributeUsage =>
                {
                   AttributeUsage attributeUsage = new AttributeUsage(this, Scope);
                   attributeUsage.Construct(syntaxAttributeUsage);
                   AttributeUsages.Add(attributeUsage);
                });
            }
            //TypeDefinition
            string strType = string.Empty;
            var syntaxReturnType = syntaxFunctionDeclaration.GetChild(3).CastTo<CommonTree>();
            syntaxReturnType.Children.ForEach(node => strType += node.Text);
            //TypeDefinition = TreeHelper.GetReturnType(syntaxFunctionDeclaration.GetChild(1).GetChild(0).Text);
            TypeDefinition = TreeHelper.GetReturnType(strType);
            //Parameters
            var syntaxParametersNode = syntaxFunctionDeclaration.GetChild(4).CastTo<CommonTree>();
            if (syntaxParametersNode.ChildCount > 0)
            {
                syntaxParametersNode.Children.Cast<CommonTree>()
                    .ForEach(syntaxParameter =>
                    {
                        FunctionVariableDeclarationParameter functionVariableDeclarationParameter =
                            new FunctionVariableDeclarationParameter(this, Scope);
                        ParameterNodes.Add(functionVariableDeclarationParameter);
//                        Scope.AddVariable(functionDeclarationParameter);
                        functionVariableDeclarationParameter.Construct(syntaxParameter);
                    });
            }

            //Statements
            var syntaxFunctionBody = syntaxFunctionDeclaration.GetChild(5).CastTo<CommonTree>();
            //StatemenBlock = TreeHelper.GetStatements(this, Scope, syntaxStatementBlock)
            //    .First().CastTo<BlockStatement>();
            if (syntaxFunctionBody.ChildCount > 0)
            {
                StatementBlock = new BlockStatement(this, Scope, false);
                StatementBlock.Construct(syntaxFunctionBody.GetChild(0).CastTo<CommonTree>());
            }
        }
    }
}