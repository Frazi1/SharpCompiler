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
        public INode Parent { get; }
        public Scope Scope { get; }

        public string Name { get; set; }
        public List<VariableDeclaration> VarDeclarationNodes { get; }
        public List<FunctionDeclaration> FunctionDeclarationNodes { get; }

        public ClassDeclaration(INode parent, Scope parentScope)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope, true);
            VarDeclarationNodes = new List<VariableDeclaration>();
            FunctionDeclarationNodes = new List<FunctionDeclaration>();
        }

        public void Construct(CommonTree syntaxClass)
        {
            Name = syntaxClass.Children[0].Text;
            var classblock = syntaxClass.GetChild(1).CastTo<CommonTree>();
            classblock.Children
                .Cast<CommonTree>()
                .ForEach(child =>
                {
                    if (child.Type == MathLangParser.STATIC_DECLARATION)
                    {
                        List<VariableDeclaration> variableList 
                            =  TreeHelper.RunMultiDeclaration(this, Scope, child.GetChild(0).CastTo<CommonTree>());
                        VarDeclarationNodes.AddRange(variableList);
                    }
                    else if (child.Type == MathLangParser.FUNCDECLARATION)
                    {
                        FunctionDeclaration function = new FunctionDeclaration(this, Scope);
                        FunctionDeclarationNodes.Add(function);
                        Scope.AddFunction(function);
                        function.Construct(child);
                    }
                });
        }
    }
}