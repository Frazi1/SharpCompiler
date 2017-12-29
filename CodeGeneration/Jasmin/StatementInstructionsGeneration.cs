using System;
using System.Collections.Generic;
using System.Linq;
using JasminSharp;
using MathLang.CodeGeneration.Helpers.Converters;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using static MathLang.CodeGeneration.CombinedInstuctionsGeneration;
using static MathLang.CodeGeneration.Instructions;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class StatementInstructionsGeneration
    {
        public static IEnumerable<IInstruction> GetInstructions(this IStatement statement)
        {
            switch (statement)
            {
                //case FunctionDeclarationParameter functionDeclarationParameter:
                //    break;
                case VariableDeclaration declaration:
                    return declaration.GetDeclarationInstructions();
                //case BoolExpression boolExpression:
                //    break;
                //case CharExpression charExpression:
                //    break;
                //case IntExpression intExpression:
                //    break;
                //case VoidExpression voidExpression:
                //    break;
                //case Atom atom:
                //    break;
                //case ExtendedId extendedId:
                //    break;
                case FunctionCall functionCall:
                    return functionCall.GetFunctionCallInstructions();
                //case NewArray newArray:
                //    break;
                case ArrayElementAssignment arrayElementAssignment:
                    return arrayElementAssignment.GetArrayElementAssignmentInstructions();
                //case DoWhileStatement doWhileStatement:
                //    break;
                case ForStatement forStatement:
                    return forStatement.GetForStatementInstructions();
                case IfStatement ifStatement:
                    return ifStatement.GetIfStatementInstructions();
                case ReturnStatement returnStatement:
                    return returnStatement.GetReturnStatementInstruction();
                case VariableAssignment variableAssignment:
                    return variableAssignment.GetVariableAssignmentInstructions();
                case WhileStatement whileStatement:
                    return whileStatement.GetWhileStatementInstructions();
                case BlockStatement blockStatement:
                    return blockStatement.GetBlockStatementInstructions();
                default: throw new NotImplementedException($"Statement generation of {statement}");
            }
        }

        private static IEnumerable<IInstruction> GetReturnStatementInstruction(
            this ReturnStatement returnStatement)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.AddRange(returnStatement.ReturnExpression.GetInstructions());
            if (returnStatement.ReturnExpression.ReturnType == ReturnType.Int
                || returnStatement.ReturnExpression.ReturnType == ReturnType.Bool
                || returnStatement.ReturnExpression.ReturnType == ReturnType.Char)
                instructions.Add(IreturnInstruction);
            else if (returnStatement.ReturnExpression.ReturnType == ReturnType.String)
                instructions.Add(AreturnInstruction);
            else
                instructions.Add(ReturnInstruction);
            return instructions;
        }

        private static IEnumerable<IInstruction> GetVariableAssignmentInstructions(
            this VariableAssignment variableAssignment)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.AddRange(variableAssignment.AssignmentValue.GetInstructions());
            if (variableAssignment.VariableName.VariableDeclaration.IsStatic)
            {
                instructions.Add(Instructions.PutStaticInstruction
                    .WithFieldName(variableAssignment.VariableName.VariableDeclaration.FullName)
                    .WithSignature(variableAssignment.VariableName.ReturnType.ConvertToFullRepresentation()));
            }
            else
            {
                instructions.Add(GetStoreInstruction(
                    variableAssignment.VariableName.VariableDeclaration.ReturnType,
                    variableAssignment.VariableName.VariableDeclaration.Index.Value));
            }
            return instructions;
        }

        private static IEnumerable<IInstruction> GetDeclarationInstructions(
            this VariableDeclaration variableDeclaration)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            if (variableDeclaration.Initialized)
            {
                instructions.AddRange(variableDeclaration.Value.GetInstructions());

                if (variableDeclaration.IsStatic)
                    instructions.Add(Instructions.PutStaticInstruction
                        .WithFieldName(variableDeclaration.FullName)
                        .WithSignature(variableDeclaration.ReturnType.ConvertToFullRepresentation()));
                else
                    instructions.Add(GetStoreInstruction(variableDeclaration.ReturnType,
                        variableDeclaration.Index.Value));
            }
            return instructions;
        }

 

        private static IEnumerable<IInstruction> GetArrayElementAssignmentInstructions(
            this ArrayElementAssignment arrayElementAssignment)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.Add(GetLoadInstruction(
                arrayElementAssignment.ArrayElementReference.ArrayDeclaration.ReturnType,
                arrayElementAssignment.ArrayElementReference.ArrayDeclaration.Index.Value));
            instructions.AddRange(arrayElementAssignment.ArrayElementReference.ArrayIndex.GetInstructions());
            instructions.AddRange(arrayElementAssignment.AssignmentExpression.GetInstructions());
            instructions.Add(GetArrayStoreInstruction(arrayElementAssignment.AssignmentExpression.ReturnType));
            return instructions;
        }

        private static IEnumerable<IInstruction> GetIfStatementInstructions(this IfStatement ifStatement)
        {
            return InstructionsBuilder.BuildIf(ifStatement.ConditionExpression.GetInstructions(),
                ifStatement.TrueCaseBlockStatement.GetInstructions(),
                ifStatement.FasleCaseBlockStatement != null
                    ? ifStatement.FasleCaseBlockStatement.GetInstructions()
                    : new List<IInstruction>());
        }

        private static IEnumerable<IInstruction> GetBlockStatementInstructions(this BlockStatement blockStatement)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            blockStatement.Statements.ForEach(statement => instructions.AddRange(statement.GetInstructions()));
            return instructions;
        }

        private static IEnumerable<IInstruction> GetForStatementInstructions(this ForStatement forStatement)
        {
            return InstructionsBuilder.BuildFor(
                forStatement.InitializationStatement?.GetInstructions() ?? Enumerable.Empty<IInstruction>(),
                forStatement.BlockOrSingleStatement.GetInstructions(),
                forStatement.ConditionExpression?.GetInstructions() ?? Enumerable.Empty<IInstruction>(),
                forStatement.IterationStatement?.GetInstructions() ?? Enumerable.Empty<IInstruction>());
        }

        private static IEnumerable<IInstruction> GetWhileStatementInstructions(this WhileStatement whileStatement)
        {
            return InstructionsBuilder.BuildWhile(whileStatement.ConditionExpression.GetInstructions(),
                whileStatement.BlockOrSingleStatement.GetInstructions());
        }
    }
}