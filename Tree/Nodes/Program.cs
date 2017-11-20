using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes;

namespace MathLang.Tree.Nodes
{
    public class Program : INode
    {
        public INode Parent { get; } = null;
        public Scope Scope { get; }

        public List<ClassDeclaration> ClassNodes { get; }
        
        public Program()
        {
            Scope = new GlobalScope();
            ClassNodes = new List<ClassDeclaration>();
        }

        public void Construct(CommonTree syntaxProgram)
        {
            if(syntaxProgram.ChildCount == 0) return;
            syntaxProgram.Children
                .Cast<CommonTree>()
                .ForEach(syntaxClass =>
                {
                    ClassDeclaration classDeclaration = new ClassDeclaration(this, Scope);
                    ClassNodes.Add(classDeclaration);
//                    Scope.AddClass(classDeclaration);
                    classDeclaration.Construct(syntaxClass);
                });
        }
    }
}