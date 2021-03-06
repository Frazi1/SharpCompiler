﻿using System;
using System.Collections;
using System.Collections.Generic;
using JasminSharp;
using MathLang.CodeGeneration.Helpers.Converters;
using MathLang.CodeGeneration.JasminJava;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using static MathLang.CodeGeneration.CombinedInstuctionsGeneration;
using static MathLang.CodeGeneration.Instructions;

namespace MathLang.CodeGeneration
{
    public static class ExpressionInstructionsGeneration
    {
        public static IEnumerable<IInstruction> GetInstructions(this IExpression iexpression)
        {
            switch (iexpression)
            {
                case ArrayElementReference arrayElementReference:
                    return arrayElementReference.GetArrayElementReferenceInstructions();
                case BoolExpression boolExpression:
                    return GetBoolExpressionInstructions(boolExpression);
                case CharExpression charExpression:
                    return GetCharExpressionInstructions(charExpression);
                case IntExpression intExpression:
                    return GetIntExpressionInstructions(intExpression);
                case VoidExpression voidExpression:
                    //Nothing to do here
                    return new List<IInstruction>();
                //case Atom atom:
                //    break;
                case Expression expression:
                    return GetExpressionInstructions(expression);
                //case ExtendedId extendedId:
                //    break;
                case FunctionCall functionCall:
                    return functionCall.GetFunctionCallInstructions();
                case NewArray newArray:
                    return newArray.GetNewArrayInstructions();
                //Variable reference
                case ExtendedId extendedId:
                    return extendedId.GetVariableReferenceInstructions();

                case StringExpression stringExpression:
                    return GetStringExpressionInstruction(stringExpression);
                default:
                    throw new InvalidOperationException(
                        $"EXpressin instruction generation {iexpression} ({iexpression.GetType()})");
            }
        }

        private static IEnumerable<IInstruction> GetCharExpressionInstructions(this CharExpression charExpression)
        {
            return LdcInstruction.WithValue(charExpression.Value.ToString()).AsList();
        }

        private static IEnumerable<IInstruction> GetBoolExpressionInstructions(this BoolExpression boolExpression)
        {
            if (boolExpression.Value) return Iconst_1Instruction.AsList();
            return Iconst_0Instruction.AsList();
        }

        private static IEnumerable<IInstruction> GetVariableReferenceInstructions(this ExtendedId extendedId)
        {
            return GetLoadInstruction(extendedId.VariableDeclaration).AsList();
        }

        private static IEnumerable<IInstruction> GetStringExpressionInstruction(this StringExpression stringExpression)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.Add(LdcInstruction.WithValue(stringExpression.Value));
            return instructions;
        }


        private static IEnumerable<IInstruction> GetIntExpressionInstructions(this IntExpression intExpression)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.Add(LdcInstruction.WithValue(intExpression.Value.ToString()));
            //instructions.AddRange(JasminLibraryFunctionsHelper.GetIntegerValueOf(JasminReferenceConstants.JavaIntegerClass));
            return instructions;
        }

        private static IEnumerable<IInstruction> GetExpressionInstructions(this Expression expression)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            //instructions.AddRange(expression.Left.GetInstructions());
            //if (expression.Right != null)
            //    instructions.AddRange(expression.Right.GetInstructions());
            switch (expression.ExpressionType)
            {
                case Tree.Nodes.Enums.ExpressionType.Add:
                    instructions.AddRange(
                        GetArithmethicsInstuction(
                            expression.Left.GetInstructions(),
                            expression.Right.GetInstructions(),
                            GetAddInstruction(expression.Left.ReturnType)));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Sub:
                    instructions.AddRange(
                        GetArithmethicsInstuction(
                            expression.Left.GetInstructions(),
                            expression.Right.GetInstructions(),
                            GetSubInstruction(expression.Left.ReturnType)));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Mul:
                    instructions.AddRange(
                        GetArithmethicsInstuction(
                            expression.Left.GetInstructions(),
                            expression.Right.GetInstructions(),
                            GetMulInstruction(expression.Left.ReturnType)));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Div:
                    instructions.AddRange(
                        GetArithmethicsInstuction(
                            expression.Left.GetInstructions(),
                            expression.Right.GetInstructions(),
                            GetDivInstruction(expression.Left.ReturnType)));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Equal:
                    instructions.AddRange(InstructionsBuilder.BuildCompareInstrution(expression.Left.GetInstructions(),
                        expression.Right.GetInstructions(), If_icmpeqInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Greater:
                    instructions.AddRange(InstructionsBuilder.BuildCompareInstrution(expression.Left.GetInstructions(),
                        expression.Right.GetInstructions(), If_icmpgtInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.EqualOrGreater:
                    instructions.AddRange(InstructionsBuilder.BuildCompareInstrution(expression.Left.GetInstructions(),
                        expression.Right.GetInstructions(), If_icmpgeInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Less:
                    instructions.AddRange(InstructionsBuilder.BuildCompareInstrution(expression.Left.GetInstructions(),
                        expression.Right.GetInstructions(), If_icmpltInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.EqualOrLess:
                    instructions.AddRange(InstructionsBuilder.BuildCompareInstrution(expression.Left.GetInstructions(),
                        expression.Right.GetInstructions(), If_icmpleInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.NotEqual:
                    instructions.AddRange(InstructionsBuilder.BuildCompareInstrution(expression.Left.GetInstructions(),
                        expression.Right.GetInstructions(), If_icmpneInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Not:
                    return InstructionsBuilder.BuildLogicalNot(expression.Left.GetInstructions());
                case Tree.Nodes.Enums.ExpressionType.Or:
                    return InstructionsBuilder.BuildLogicalOr(expression.Left.GetInstructions(),
                        expression.Right.GetInstructions());
                case Tree.Nodes.Enums.ExpressionType.And:
                    return InstructionsBuilder.BuildLogicalAnd(expression.Left.GetInstructions(),
                        expression.Right.GetInstructions());
                //case Tree.Nodes.Enums.ExpressionType.FunctionCall:
                //    break;
                //case Tree.Nodes.Enums.ExpressionType.VariableDeclaration:
                //    break;
                //case Tree.Nodes.Enums.ExpressionType.VariableReference:
                //    break;
                case Tree.Nodes.Enums.ExpressionType.ArrayElementReference:
                    break;
                default: throw new NotImplementedException($"Expression code generation: {expression}");
            }
            return instructions;
        }

        private static IEnumerable<IInstruction> GetArithmethicsInstuction(IEnumerable<IInstruction> left,
            IEnumerable<IInstruction> right, IInstruction arithmeticsInstruction)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.AddRange(left);
            instructions.AddRange(right);
            instructions.Add(arithmeticsInstruction);
            return instructions;
        }


        private static IInstruction GetSubInstruction(ReturnType returnType)
        {
            switch (returnType)
            {
                case IntReturnType intReturnType:
                    return IsubInstruction;
                default: throw new NotImplementedException($"GetSubInstuction: {nameof(returnType)}");
            }
        }

        private static IInstruction GetMulInstruction(ReturnType returnType)
        {
            switch (returnType)
            {
                case IntReturnType intReturnType:
                    return ImulInstruction;
                default: throw new NotImplementedException($"GetMulInstuction: {nameof(returnType)}");
            }
        }

        private static IInstruction GetDivInstruction(ReturnType returnType)
        {
            switch (returnType)
            {
                case IntReturnType intReturnType:
                    return IdivInstruction;
                default: throw new NotImplementedException($"GetDivInstuction: {nameof(returnType)}");
            }
        }

        private static IInstruction GetAddInstruction(ReturnType returnType)
        {
            switch (returnType)
            {
                case IntReturnType intReturnType:
                    return IaddInstruction;
                default: throw new NotImplementedException($"GetAddInstuction: {nameof(returnType)}");
            }
        }

        private static IEnumerable<IInstruction> GetNewArrayInstructions(this NewArray newArray)
        {
            JasminTypeArgumentInstruction arrayCreationInstruction = newArray.InnerElementsReturnType.IsPrimitiveType()
                ? (JasminTypeArgumentInstruction) Instructions.NewArrayInstruction
                : Instructions.ANewArrayInstruction;

            List<IInstruction> instructions = new List<IInstruction>();
            instructions.AddRange(newArray.ArraySize.GetInstructions());

            instructions.Add(
                arrayCreationInstruction.WithType(newArray.InnerElementsReturnType.ConvertToKeywordRepresentation()));
            return instructions;
        }

        private static IEnumerable<IInstruction> GetArrayElementReferenceInstructions(
            this ArrayElementReference arrayElementReference)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.Add(GetLoadInstruction(arrayElementReference.ArrayDeclaration));
            instructions.AddRange(arrayElementReference.ArrayIndex.GetInstructions());
            instructions.Add(GetArrayLoadInstruction(arrayElementReference.ReturnType));
            return instructions;
        }
    }
}