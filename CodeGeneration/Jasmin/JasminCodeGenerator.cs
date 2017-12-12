using System;
using System.Linq;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Statements;

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
            JasminClassModule jasminClass = new JasminClassModule(classDeclaration.Name);
            if(classDeclaration.IsStatic)
                jasminClass.AddModifiers(JasminModifier.Final);
            jasminClass.AddModifiers(JasminModifier.Public);
            jasminClass.GenerateListing().ForEach(PushLine);
            //PushLine($"{Class} {Public} "
            //         + $"{(classDeclaration.IsStatic ? Final + " " : string.Empty)}"
            //         + $"{classDeclaration.Name}");
            //PushLine($"{Super} {JasminReferenceConstants.JavaObject}");
            //classDeclaration.FunctionDeclarationNodes.ForEach(GenerateFunctionCode);
            
        }

        //private void GenerateFunctionCode(FunctionDeclaration functionDeclaration)
        //{
        //    PushLine($"{Method} {Static} {functionDeclaration.Name}(");
        //    //GenerateStatementBlockCode(functionDeclaration.StatemenBlock);
        //    PushLine($"{EndMethod}");
        //}

        private void GenerateStatementBlockCode(BlockStatement functionDeclarationStatemenBlock)
        {
            throw new NotImplementedException();
        }
    }
}