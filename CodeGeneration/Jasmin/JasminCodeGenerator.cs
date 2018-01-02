using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JasminSharp;
using MathLang.CodeGeneration.Helpers.Converters;
using MathLang.CodeGeneration.JasminJava;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;

namespace MathLang.CodeGeneration
{
    public class JasminCodeGenerator
    {
        public string CodeListing { get; private set; } = "";

        private readonly Dictionary<string, string> _classListings = new Dictionary<string, string>();

        public void GenerateCode(Tree.Nodes.Program program)
        {
            program.ClassNodes.ForEach(GenerateClassCode);
        }

        private void GenerateClassCode(ClassDeclaration classDeclaration)
        {
            if (classDeclaration.IsExtern || !classDeclaration.CodeGeneration) return;

            JasminModifier classModifier = JasminModifier.Public;
            if (classDeclaration.IsStatic) classModifier |= JasminModifier.Final;

            JasminClassModule jasminClass = new JasminClassModule(classDeclaration.Name)
                .WithModifier(classModifier);

            classDeclaration.VarDeclarationNodes.ForEach(declaration =>
            {
                if (declaration.Initialized)
                    jasminClass.WithField(BuildJasminStaticVariable(declaration));
            });

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
                .WithName(function.NameCamelCased/*.ToCamelCase()*/)
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

        public JasminFunctionParameter BuildJasminFunctionParameter(
            FunctionVariableDeclarationParameter functionVariableParameter)
        {
            JasminFunctionParameter jasminFunctionParameter =
                new JasminFunctionParameter()
                    .WithName(functionVariableParameter.Name)
                    .WithType(ReturnTypeToJavaConverter.ConvertToFullRepresentation(
                        functionVariableParameter.ReturnType));
            return jasminFunctionParameter;
        }

        public JasminField BuildJasminStaticVariable(VariableDeclaration variableDeclaration)
        {
            if (!variableDeclaration.IsStatic)
                throw new Exception($"{variableDeclaration} is not static!");

            JasminModifier modifier = JasminModifier.Public;
            if (variableDeclaration.IsStatic)
                modifier |= JasminModifier.Static;

            var fieldInitializationInstructions = variableDeclaration.Value.GetInstructions().ToList();
            fieldInitializationInstructions.Add(Instructions.PutStaticInstruction
                .WithFieldName(variableDeclaration.FullName)
                .WithSignature(variableDeclaration.ReturnType.ConvertToFullRepresentation()));

            JasminField jasminField = new JasminField()
                .WithName(variableDeclaration.Name)
                .WithSignature(variableDeclaration.ReturnType.ConvertToFullRepresentation())
                .WithModifier(modifier)
                .WithValue(fieldInitializationInstructions);
            return jasminField;
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