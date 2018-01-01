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
                        ReturnTypeToJavaConverter.ConvertToFullRepresentation(functionDeclaration.TypeDefinition));
                functionDeclaration
                    .ParameterNodes
                    .Select(parameter => ReturnTypeToJavaConverter.ConvertToFullRepresentation(parameter.TypeDefinition))
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
                    .WithReturnType(ReturnTypeToJavaConverter.ConvertToFullRepresentation(functionCall.TypeDefinition));
                functionDeclaration
                    .ParameterNodes
                    .Select(parameter => ReturnTypeToJavaConverter.ConvertToFullRepresentation(parameter.TypeDefinition))
                    .ForEach(typeName => invokestaticInstruction.WithParameterType(typeName));
                instructions.Add(invokestaticInstruction);
            }
            return instructions;
        }

        public static IInstruction GetStoreInstruction(VariableDeclaration variableDeclaration)
        {
            if (variableDeclaration.IsStatic)
            {
                return Instructions.PutStaticInstruction.WithFieldName(variableDeclaration.FullName)
                    .WithSignature(variableDeclaration.TypeDefinition.ConvertToFullRepresentation());
            }
            int index = variableDeclaration.Index.Value;
            switch (variableDeclaration.TypeDefinition)
            {
                case BoolTypeDefinition boolReturnType:
                    return IstoreInstruction.WithIndex(index);
                case CharTypeDefinition charReturnType:
                    return IstoreInstruction.WithIndex(index);
                case ArrayTypeDefinition arrayReturnType:
                    return AstoreInstruction.WithIndex(index);
                case IntTypeDefinition intReturnType:
                    return IstoreInstruction.WithIndex(index);
                case StringTypeDefinition stringReturnType:
                    return AstoreInstruction.WithIndex(index);
                default:
                    throw new NotImplementedException(nameof(TypeDefinition) + "store instruction generation");
            }
        }

        public static IInstruction GetLoadInstruction(VariableDeclaration variableDeclaration)
        {
            if (variableDeclaration.IsStatic)
                return Instructions.GetStaticInstruction.WithFieldName(variableDeclaration.FullName)
                    .WithSignature(variableDeclaration.TypeDefinition.ConvertToFullRepresentation());
            int index = variableDeclaration.Index.Value;
            switch (variableDeclaration.TypeDefinition)
            {
                case BoolTypeDefinition boolReturnType:
                    return IloadInstruction.WithIndex(index);
                case CharTypeDefinition charReturnType:
                    return IloadInstruction.WithIndex(index);
                case ArrayTypeDefinition arrayReturnType:
                    return AloadInstruction.WithIndex(index);
                case IntTypeDefinition intReturnType:
                    return IloadInstruction.WithIndex(index);
                case StringTypeDefinition stringReturnType:
                    return AloadInstruction.WithIndex(index);
                default:
                    throw new NotImplementedException(nameof(TypeDefinition) + " load instruction generation");
            }
        }

        public static NoArgumentInstruction GetArrayLoadInstruction(TypeDefinition typeDefinition)
        {
            switch (typeDefinition)
            {
                case BoolTypeDefinition boolReturnType:
                    return BaloadInstruction;
                case CharTypeDefinition charReturnType:
                    return CaloadInstruction;
                case ArrayTypeDefinition arrayReturnType:
                    return AaloadInstruction;
                case IntTypeDefinition intReturnType:
                    return IaloadInstruction;
                case StringTypeDefinition stringReturnType:
                    return AaloadInstruction;
                default:
                    throw new NotImplementedException(nameof(TypeDefinition) + " array load instruction generation");
            }
        }

        public static NoArgumentInstruction GetArrayStoreInstruction(TypeDefinition typeDefinition)
        {
            switch (typeDefinition)
            {
                case BoolTypeDefinition boolReturnType:
                    return BastoreInstruction;
                case CharTypeDefinition charReturnType:
                    return CastoreInstruction;
                case ArrayTypeDefinition arrayReturnType:
                    return AastoreInstruction;
                case IntTypeDefinition intReturnType:
                    return IastoreInstruction;
                case StringTypeDefinition stringReturnType:
                    return AastoreInstruction;
                default:
                    throw new NotImplementedException(nameof(TypeDefinition) + " array load instruction generation");
            }
        }
    }
}