using System.Collections.Generic;
using System.Linq;
using JasminSharp;
using MathLang.CodeGeneration.Helpers.Converters;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Expressions;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class CombinedInstuctionsGeneration
    {
        public static IEnumerable<IInstruction> GetFunctionCallInstructions(this FunctionCall functionCall)
        {
            List<IInstruction> instructions = new List<IInstruction>();

            //Add parameters to stack
            functionCall.FunctionCallParameters.ReverseForEach(expression =>
            {
                instructions.AddRange(expression.GetInstructions());
            });

            var scope = functionCall.Scope;
            FunctionDeclaration functionDeclaration = scope.GlobalFunctionSearch(functionCall.ExtendedId.Name);
            var javaRefAtrribute =
                functionDeclaration.AttributeUsages.Find(usage => usage.Name.Name == "JavaRef");
            if (javaRefAtrribute != null)
            {
                string externName = javaRefAtrribute.FunctionCallParameters
                    .First()
                    .CastTo<StringExpression>()
                    .Value
                    .RemoveFirstAndLastCharacters();
                invokestaticInstruction invokestaticInstruction = Instructions.InvokestaticInstruction
                    .WithMethodFullName(externName)
                    .WithReturnType(ReturnTypeToJavaConverter.ConvertToJasminRepresentation(functionDeclaration.ReturnType));
                functionDeclaration
                    .ParameterNodes
                    .Select(parameter => ReturnTypeToJavaConverter.ConvertToJasminRepresentation(parameter.ReturnType))
                    .ForEach(typeName => invokestaticInstruction.WithParameterType(typeName));
                instructions.Add(invokestaticInstruction);
            }
            else
            {
                //var splittedName = functionCall.FunctionDeclaration.FullName.Split('.');
                //string correctedName;
                //if (splittedName.Length == 1)
                //    correctedName = splittedName[0].ToCamelCase();
                //else
                //    correctedName = $"{splittedName[0]}/{splittedName[1].ToCamelCase()}";
                invokestaticInstruction invokestaticInstruction = Instructions.InvokestaticInstruction
                    .WithMethodFullName(/*correctedName*/functionCall.FunctionDeclaration.FullName)
                    .WithReturnType(ReturnTypeToJavaConverter.ConvertToJasminRepresentation(functionCall.ReturnType));
                functionDeclaration
                    .ParameterNodes
                    .Select(parameter => ReturnTypeToJavaConverter.ConvertToJasminRepresentation(parameter.ReturnType))
                    .ForEach(typeName => invokestaticInstruction.WithParameterType(typeName));
                instructions.Add(invokestaticInstruction);
            }
            return instructions;
        }
    }
}