using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;

namespace MathLang.Tree.Nodes
{
    public class Program : INode
    {
        public INode Parent { get; set; }
        public List<ClassDeclaration> ClassNodes { get; }

        public Program()
        {
            ClassNodes = new List<ClassDeclaration>();
        }

        public void Construct(CommonTree syntaxProgram)
        {
            syntaxProgram.Children
                .Cast<CommonTree>()
                .ForEach(syntaxClass =>
                {
                    ClassDeclaration classDeclaration = new ClassDeclaration(this);
                    ClassNodes.Add(classDeclaration);
                    classDeclaration.Construct(syntaxClass);
                });
        }
    }
}