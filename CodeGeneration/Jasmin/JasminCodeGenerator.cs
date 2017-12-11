
using System;
using MathLang.Tree.Nodes.Declarations;
using static MathLang.CodeGeneration.Jasmin.JasminTokens;

namespace MathLang.CodeGeneration.Jasmin
{
    public class JasminCodeGenerator
    {
        public string CodeListing { get; private set; } = "";


        private void PushLine(string text)
        {
            CodeListing += text + Environment.NewLine;
        }
        
        public void GenerateCode(Tree.Nodes.Program program)
        {
            program.ClassNodes.ForEach(GenerateClassCode);
        }

        private void GenerateClassCode(ClassDeclaration classDeclaration)
        {
            PushLine($"{Class} {Public} {classDeclaration.Name}");
        }
    }
}