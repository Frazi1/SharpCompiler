using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using static MathLang.CodeGeneration.JasminJava.Instructions;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class ExpressionInstructionsGeneration
    {
        public static IEnumerable<IInstruction> GetInstructions(this IExpression iexpression)
        {
            switch (iexpression)
            {
                //case ArrayElementReference arrayElementReference:
                //    break;
                case BoolExpression boolExpression:
                    return GetBoolExpressionInstructions(boolExpression);
                case CharExpression charExpression:
                    return GetCharExpressionInstructions(charExpression);
                case IntExpression intExpression:
                    return GetIntExpressionInstructions(intExpression);
                //case VoidExpression voidExpression:
                //    break;
                //case Atom atom:
                //    break;
                case Expression expression:
                    return GetExpressionInstructions(expression);
                //case ExtendedId extendedId:
                //    break;
                case FunctionCall functionCall:
                    return functionCall.GetFunctionCallInstructions();
                //case NewArray newArray:
                //    break;
                //Variable reference
                case ExtendedId extendedId:
                    return extendedId.GetVariableReferenceInstructions();
                
                case VariableReference variableReference:
                    throw new InvalidOperationException($"EXpressin instruction generation {iexpression}");
                    break;
                case StringExpression stringExpression:
                    return GetStringExpressionInstruction(stringExpression);
                default:
                    throw new InvalidOperationException($"EXpressin instruction generation {iexpression} ({iexpression.GetType()})");
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
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.Add(StatementInstructionsGeneration.GetLoadInstruction(extendedId.Declaration.ReturnType,
                extendedId.Declaration.Index.Value));
            return instructions;
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
            instructions.AddRange(expression.Left.GetInstructions());
            if (expression.Right != null)
                instructions.AddRange(expression.Right.GetInstructions());
            switch (expression.ExpressionType)
            {
                case Tree.Nodes.Enums.ExpressionType.Add:
                    instructions.Add(GetAddInstruction(expression.Left.ReturnType));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Sub:
                    instructions.Add(GetSubInstruction(expression.Left.ReturnType));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Mul:
                    instructions.Add(GetMulInstruction(expression.Left.ReturnType));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Div:
                    instructions.Add(GetDivInstruction(expression.Left.ReturnType));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Equal:
                    instructions.AddRange(InstuctionsBuilder.BuildCompareInstrution(If_icmpeqInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Greater:
                    instructions.AddRange(InstuctionsBuilder.BuildCompareInstrution(If_icmpgtInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.EqualOrGreater:
                    instructions.AddRange(InstuctionsBuilder.BuildCompareInstrution(If_icmpgeInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.Less:
                    instructions.AddRange(InstuctionsBuilder.BuildCompareInstrution(If_icmpltInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.EqualOrLess:
                    instructions.AddRange(InstuctionsBuilder.BuildCompareInstrution(If_icmpleInstruction));
                    break;
                case Tree.Nodes.Enums.ExpressionType.NotEqual:
                    instructions.AddRange(InstuctionsBuilder.BuildCompareInstrution(If_icmpneInstruction));
                    break;
                //case Tree.Nodes.Enums.ExpressionType.Not:
                //    break;
                //case Tree.Nodes.Enums.ExpressionType.Or:
                //    break;
                //case Tree.Nodes.Enums.ExpressionType.And:
                //    break;
                //case Tree.Nodes.Enums.ExpressionType.FunctionCall:
                //    break;
                //case Tree.Nodes.Enums.ExpressionType.VariableDeclaration:
                //    break;
                //case Tree.Nodes.Enums.ExpressionType.VariableReference:
                //    break;
                //case Tree.Nodes.Enums.ExpressionType.ArrayElementReference:
                //    break;
                default: throw new NotImplementedException($"Expression code generation: {expression}");
            }
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
    }
}