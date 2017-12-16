using System;
using System.Collections.Generic;
using MathLang.CodeGeneration.JasminJava.Library;
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
                //case Expression expression:
                //    break;
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
            instructions.Add(BipushInstruction.WithArgument(intExpression.Value));
            instructions.AddRange(JasminLibraryFunctionsHelper.GetIntegerValueOf(JasminReferenceConstants.JavaInteger));
            return instructions;
        }
    }
}