using System;
using System.Linq;
using MathLang.CodeGeneration.Helpers;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Statements;
using static JasminSharp.Jasmin;

namespace MathLang.CodeGeneration.JasminJava
{
    public class JasminCodeGenerator
    {

        public JasminCodeGenerator()
        {
            JasminMappingsInitializer.Initilalize();
        }
        
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
            if (classDeclaration.IsStatic)
                jasminClass.WithModifiers(JasminModifier.Final);

            classDeclaration.FunctionDeclarationNodes.ForEach(function =>
                jasminClass.WithFunction(BuildJasminFunction(function)));
            jasminClass.GenerateListing().ForEach(PushLine);
            //PushLine($"{Class} {Public} "
            //         + $"{(classDeclaration.IsStatic ? Final + " " : string.Empty)}"
            //         + $"{classDeclaration.Name}");
            //PushLine($"{Super} {JasminReferenceConstants.JavaObject}");
            //classDeclaration.FunctionDeclarationNodes.ForEach(GenerateFunctionCode);
        }

        public JasminFunctionModule BuildJasminFunction(FunctionDeclaration function)
        {
            JasminFunctionModule jasminFunction = new JasminFunctionModule()
                .WithName(function.Name.ToCamelCase())
                .WithModifiers(JasminModifier.Public, JasminModifier.Static)
                .WithReturnType(Mapper.Map<string>(function.ReturnType));

            function.ParameterNodes.ForEach(functionParameter => 
                jasminFunction.WithParameter(BuildJasminFunctionParameter(functionParameter)));
            return jasminFunction;
        }

        public JasminFunctionParameter BuildJasminFunctionParameter(FunctionDeclarationParameter functionParameter)
        {
            JasminFunctionParameter jasminFunctionParameter =
                new JasminFunctionParameter()
                    .WithName(functionParameter.Name)
                    .WithType(Mapper.Map<string>(functionParameter.ReturnType));
            return jasminFunctionParameter;
        }

        private void GenerateStatementBlockCode(BlockStatement functionDeclarationStatemenBlock)
        {
            throw new NotImplementedException();
        }
    }
}