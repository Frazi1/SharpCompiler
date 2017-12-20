using System;
using System.Collections.Generic;
using JasminSharp;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using static MathLang.CodeGeneration.JasminJava.InstructionsHelper;

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
                case VariableDeclaration variableDeclaration:
                    return variableDeclaration.GetVariableDeclarationInstructions();
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
                //case ArrayElementAssignment arrayElementAssignment:
                //    break;
                //case BlockStatement blockStatement:
                //    break;
                //case DoWhileStatement doWhileStatement:
                //    break;
                //case ForStatement forStatement:
                //    break;
                //case IfStatement ifStatement:
                //    break;
                //case ReturnStatement returnStatement:
                //    break;
                case VariableAssignment variableAssignment:
                    return variableAssignment.GetVariableAssignmentInstructions();
                //case WhileStatement whileStatement:
                //    break;
                default: throw new NotImplementedException($"Statement generation of {statement}");
            }
        }

        private static IEnumerable<IInstruction> GetVariableAssignmentInstructions(
            this VariableAssignment variableAssignment)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.AddRange(variableAssignment.AssignmentValue.GetInstructions());
            instructions.Add(GetStoreInstruction(
                variableAssignment.VariableName.Declaration.ReturnType,
                variableAssignment.VariableName.Declaration.Index.Value));
            return instructions;
        }

        private static IEnumerable<IInstruction> GetVariableDeclarationInstructions(
            this VariableDeclaration variableDeclaration)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            if (variableDeclaration.IsStatic) throw new JasminException("static decl are not supported atm");
            else
            {
                instructions.AddRange(variableDeclaration.Value.GetInstructions());
                IIndexedInstruction storeInstruction = null;
                instructions.Add(GetStoreInstruction(variableDeclaration.ReturnType, variableDeclaration.Index.Value));
            }
            return instructions;
        }

        private static IIndexedInstruction GetStoreInstruction(ReturnType returnType, int index)
        {
            switch (returnType)
            {
                case BoolReturnType boolReturnType:
                    throw new NotImplementedException(nameof(ReturnType) + "store instruction generation");
                    break;
                case CharReturnType charReturnType:
                    throw new NotImplementedException(nameof(ReturnType) + "store instruction generation");
                    break;
                case ArrayReturnType arrayReturnType:
                    throw new NotImplementedException(nameof(ReturnType) + "store instruction generation");
                    break;
                case IntReturnType intReturnType:
                    return IstoreInstruction.WithIndex(index);
                default:
                    throw new NotImplementedException(nameof(ReturnType) + "store instruction generation");
            }
        }
    }
}