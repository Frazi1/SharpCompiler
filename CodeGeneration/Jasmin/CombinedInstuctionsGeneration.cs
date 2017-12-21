using System.Collections.Generic;
using System.Linq;
using JasminSharp;
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
            FunctionDeclaration functionDeclaration = scope.GlobalFunctionSearch(functionCall.Name.GetFullPath);
            var javaRefAtrribute =
                functionDeclaration.AttributeUsages.Find(usage => usage.Name.GetFullPath == "JavaRef");
            if (javaRefAtrribute != null)
            {
                string externName = javaRefAtrribute.FunctionCallParameters
                    .First()
                    .CastTo<StringExpression>()
                    .Value
                    .RemoveFirstAndLastCharacters();
                invokestaticInstruction invokestaticInstruction = InstructionsHelper.InvokestaticInstruction
                    .WithMethodFullName(externName)
                    .WithReturnType(Jasmin.TypeMapper.Map<string>(functionDeclaration.ReturnType));
                functionDeclaration
                    .ParameterNodes
                    .Select(parameter => Jasmin.TypeMapper.Map<string>(parameter.ReturnType))
                    .ForEach(typeName => invokestaticInstruction.WithParameterType(typeName));
                instructions.Add(invokestaticInstruction);
            }
            return instructions;
        }
    }
}