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
            JasminClassModule jasminClass = new JasminClassModule(classDeclaration.Name)
                .WithModifiers(JasminModifier.Public);
            if(classDeclaration.IsStatic)
                jasminClass.WithModifiers(JasminModifier.Final);
           
            classDeclaration.FunctionDeclarationNodes.ForEach(function => jasminClass.WithFunction(BuildJasminFunction(function)));
            jasminClass.GenerateListing().ForEach(PushLine);
            //PushLine($"{Class} {Public} "
            //         + $"{(classDeclaration.IsStatic ? Final + " " : string.Empty)}"
            //         + $"{classDeclaration.Name}");
            //PushLine($"{Super} {JasminReferenceConstants.JavaObject}");
            //classDeclaration.FunctionDeclarationNodes.ForEach(GenerateFunctionCode);
            
        }

        public JasminFunctionModule BuildJasminFunction(FunctionDeclaration function)
        {
            JasminFunctionModule jasminFunction = new JasminFunctionModule(function.Name)
                .WithModifiers(JasminModifier.Public, JasminModifier.Static);

            return jasminFunction;
        }

        private void GenerateStatementBlockCode(BlockStatement functionDeclarationStatemenBlock)
        {
            throw new NotImplementedException();
        }
    }
}