using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MathLang.CodeGeneration.Helpers;
using MathLang.CodeGeneration.Helpers.Converters;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Statements;
using static JasminSharp.Jasmin;

namespace MathLang.CodeGeneration.JasminJava
{
    public class JasminCodeGenerator
    {
        public string CodeListing { get; private set; } = "";

        private readonly Dictionary<string, string> _classListings = new Dictionary<string, string>();
        
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
            if(classDeclaration.IsExtern || !classDeclaration.CodeGeneration) return;

            JasminClassModule jasminClass = new JasminClassModule(classDeclaration.Name)
                .WithModifiers(JasminModifier.Public);
            if (classDeclaration.IsStatic)
                jasminClass.WithModifiers(JasminModifier.Final);

            classDeclaration.FunctionDeclarationNodes.ForEach(function =>
            {
                if (!function.IsExternal)
                    jasminClass.WithFunction(BuildJasminFunction(function));
            });

                _classListings.Add(jasminClass.Name, string.Empty);

            jasminClass.GenerateListing()
                .ForEach(classListing =>
                {
                    _classListings[jasminClass.Name] += classListing + Environment.NewLine;
                //_classListings.Add(jasminClass.Name, classListing + Environment.NewLine);
            });
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
                .WithReturnType(ReturnTypeToJavaConverter.ConvertToFullRepresentation(function.ReturnType));

            function.ParameterNodes.ForEach(functionParameter =>
                jasminFunction.WithParameter(BuildJasminFunctionParameter(functionParameter)));

            function.StatementBlock.Statements.ForEach(statement =>
            {
                jasminFunction.WithInstructions(statement.GetInstructions());
            });
            if (function.ReturnType == ReturnType.Void)
                jasminFunction.WithInstructions(Instructions.ReturnInstruction);
            return jasminFunction;
        }

        public JasminFunctionParameter BuildJasminFunctionParameter(FunctionDeclarationParameter functionParameter)
        {
            JasminFunctionParameter jasminFunctionParameter =
                new JasminFunctionParameter()
                    .WithName(functionParameter.Name)
                    .WithType(ReturnTypeToJavaConverter.ConvertToFullRepresentation(functionParameter.ReturnType));
            return jasminFunctionParameter;
        }

        public void SaveFiles()
        {
            _classListings.ForEach(pair =>
            {
                var writer = new StreamWriter(pair.Key + ".j");
                writer.Write(pair.Value);
                writer.Flush();
                writer.Close();
            });
            
        }
    }
}