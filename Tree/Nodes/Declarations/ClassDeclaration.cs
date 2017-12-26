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
        public bool IsPrintable { get; }
        
        public ClassDeclaration(INode parent, Scope parentScope, bool isPrintable = true)
        {
            Parent = parent;
            Scope = new LocalScope(parentScope);
            IsPrintable = isPrintable;
        }

        public void Construct(CommonTree syntaxClass)
        {
            Name = syntaxClass.Children[0].Text;
            var classblock = syntaxClass.GetChild(1).CastTo<CommonTree>();
            if(classblock.ChildCount == 0) return;
            classblock.Children
                .Cast<CommonTree>()
                .ForEach(child =>
                {
                    if (child.Type == MathLangParser.STATIC_DECLARATION)
                    {
                        //List<VariableDeclaration> variableList 
                        //    =  TreeHelper.RunMultiDeclaration(this, Scope, child.GetChild(0).CastTo<CommonTree>());
                        //VarDeclarationNodes.AddRange(variableList);
                        child.Children.Cast<CommonTree>()
                            .Select(syntaxVariableDeclaration =>
                            {
                                var variableDeclaration = TreeHelper
                                    .GetStatements(this, Scope, syntaxVariableDeclaration).First()
                                    .CastTo<VariableDeclaration>();
                                variableDeclaration.Construct(syntaxVariableDeclaration);
                                return variableDeclaration;
                            })
                            .ForEach(declaration => VarDeclarationNodes.Add(declaration));
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