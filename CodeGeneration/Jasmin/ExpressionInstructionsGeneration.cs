using System;
using System.Collections.Generic;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using static MathLang.CodeGeneration.JasminJava.InstructionsHelper;

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
                //case BoolExpression boolExpression:
                //    break;
                //case CharExpression charExpression:
                //    break;
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
                //case FunctionCall functionCall:
                //    break;
                //case NewArray newArray:
                //    break;
                //case VariableReference variableReference:
                //    break;
                default: throw new InvalidOperationException($"EXpressin instruction generation {iexpression}");
            }
        }

        private static IEnumerable<IInstruction> GetIntExpressionInstructions(IntExpression intExpression)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.Add(LdcInstruction.WithValue(intExpression.Value.ToString()));
            //instructions.AddRange(JasminLibraryFunctionsHelper.GetIntegerValueOf(JasminReferenceConstants.JavaIntegerClass));
            return instructions;
        }

        private static IEnumerable<IInstruction> GetExpressionInstructions(Expression expression)
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
                    break;
                case Tree.Nodes.Enums.ExpressionType.Greater:
                    break;
                case Tree.Nodes.Enums.ExpressionType.EqualOrGreater:
                    break;
                case Tree.Nodes.Enums.ExpressionType.Less:
                    break;
                case Tree.Nodes.Enums.ExpressionType.EqualOrLess:
                    break;
                case Tree.Nodes.Enums.ExpressionType.NotEqual:
                    break;
                case Tree.Nodes.Enums.ExpressionType.Not:
                    break;
                case Tree.Nodes.Enums.ExpressionType.Or:
                    break;
                case Tree.Nodes.Enums.ExpressionType.And:
                    break;
                case Tree.Nodes.Enums.ExpressionType.FunctionCall:
                    break;
                case Tree.Nodes.Enums.ExpressionType.VariableDeclaration:
                    break;
                case Tree.Nodes.Enums.ExpressionType.VariableReference:
                    break;
                case Tree.Nodes.Enums.ExpressionType.ArrayElementReference:
                    break;
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