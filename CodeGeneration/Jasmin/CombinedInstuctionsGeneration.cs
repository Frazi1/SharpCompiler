using System;
using System.Collections.Generic;
using System.Linq;
using JasminSharp;
using MathLang.CodeGeneration.Helpers.Converters;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using static MathLang.CodeGeneration.Instructions;

namespace MathLang.CodeGeneration
{
    public static class CombinedInstuctionsGeneration
    {
        public static IEnumerable<IInstruction> GetFunctionCallInstructions(this FunctionCall functionCall)
        {
            List<IInstruction> instructions = new List<IInstruction>();

            //Add parameters to stack
            functionCall.FunctionCallParameters.ForEach(expression =>
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
                invokestaticInstruction invokestaticInstruction = InvokestaticInstruction
                    .WithMethodFullName(externName)
                    .WithReturnType(
                        ReturnTypeToJavaConverter.ConvertToFullRepresentation(functionDeclaration.ReturnType));
                functionDeclaration
                    .ParameterNodes
                    .Select(parameter => ReturnTypeToJavaConverter.ConvertToFullRepresentation(parameter.ReturnType))
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
                invokestaticInstruction invokestaticInstruction = InvokestaticInstruction
                    .WithMethodFullName( /*correctedName*/functionCall.FunctionDeclaration.FullName)
                    .WithReturnType(ReturnTypeToJavaConverter.ConvertToFullRepresentation(functionCall.ReturnType));
                functionDeclaration
                    .ParameterNodes
                    .Select(parameter => ReturnTypeToJavaConverter.ConvertToFullRepresentation(parameter.ReturnType))
                    .ForEach(typeName => invokestaticInstruction.WithParameterType(typeName));
                instructions.Add(invokestaticInstruction);
            }
            return instructions;
        }

        public static IInstruction GetStoreInstruction(VariableDeclaration variableDeclaration)
        {
            if (variableDeclaration.IsStatic)
            {
                return Instructions.PutStaticInstruction.WithFieldName(variableDeclaration.Name)
                    .WithSignature(variableDeclaration.ReturnType.ConvertToFullRepresentation());
            }
            int index = variableDeclaration.Index.Value;
            switch (variableDeclaration.ReturnType)
            {
                case BoolReturnType boolReturnType:
                    return IstoreInstruction.WithIndex(index);
                case CharReturnType charReturnType:
                    return IstoreInstruction.WithIndex(index);
                case ArrayReturnType arrayReturnType:
                    return AstoreInstruction.WithIndex(index);
                case IntReturnType intReturnType:
                    return IstoreInstruction.WithIndex(index);
                case StringReturnType stringReturnType:
                    return AstoreInstruction.WithIndex(index);
                default:
                    throw new NotImplementedException(nameof(ReturnType) + "store instruction generation");
            }
        }

        public static IInstruction GetLoadInstruction(VariableDeclaration variableDeclaration)
        {
            if (variableDeclaration.IsStatic)
                return Instructions.GetStaticInstruction.WithFieldName(variableDeclaration.FullName)
                    .WithSignature(variableDeclaration.ReturnType.ConvertToFullRepresentation());
            int index = variableDeclaration.Index.Value;
            switch (variableDeclaration.ReturnType)
            {
                case BoolReturnType boolReturnType:
                    return IloadInstruction.WithIndex(index);
                case CharReturnType charReturnType:
                    return IloadInstruction.WithIndex(index);
                case ArrayReturnType arrayReturnType:
                    return AloadInstruction.WithIndex(index);
                case IntReturnType intReturnType:
                    return IloadInstruction.WithIndex(index);
                case StringReturnType stringReturnType:
                    return AloadInstruction.WithIndex(index);
                default:
                    throw new NotImplementedException(nameof(ReturnType) + " load instruction generation");
            }
        }

        public static NoArgumentInstruction GetArrayLoadInstruction(ReturnType returnType)
        {
            switch (returnType)
            {
                case BoolReturnType boolReturnType:
                    return BaloadInstruction;
                case CharReturnType charReturnType:
                    return CaloadInstruction;
                case ArrayReturnType arrayReturnType:
                    return AaloadInstruction;
                case IntReturnType intReturnType:
                    return IaloadInstruction;
                case StringReturnType stringReturnType:
                    return AaloadInstruction;
                default:
                    throw new NotImplementedException(nameof(ReturnType) + " array load instruction generation");
            }
        }

        public static NoArgumentInstruction GetArrayStoreInstruction(ReturnType returnType)
        {
            switch (returnType)
            {
                case BoolReturnType boolReturnType:
                    return BastoreInstruction;
                case CharReturnType charReturnType:
                    return CastoreInstruction;
                case ArrayReturnType arrayReturnType:
                    return AastoreInstruction;
                case IntReturnType intReturnType:
                    return IastoreInstruction;
                case StringReturnType stringReturnType:
                    return AastoreInstruction;
                default:
                    throw new NotImplementedException(nameof(ReturnType) + " array load instruction generation");
            }
        }
    }
}