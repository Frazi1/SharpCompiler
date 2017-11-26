using System;
using System.Collections.Generic;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Scopes.Exceptions;

namespace MathLang.Tree.Nodes.Expressions
{
    public static class CastsTable
    {
        private static List<Tuple<ReturnType, ReturnType>> CastsList { get; } =
            new List<Tuple<ReturnType, ReturnType>>();

        static CastsTable()
        {
            AddCastablePair(ReturnType.Char, ReturnType.Int);
        }

        private static void AddCastablePair(ReturnType first, ReturnType second)
        {
            CastsList.Add(new Tuple<ReturnType, ReturnType>(first, second));
            CastsList.Add(new Tuple<ReturnType, ReturnType>(second, first));
        }

        public static bool IsCastableTo(this ReturnType sourceReturnType, ReturnType targeReturnType)
        {
            return CastsList
                       .Find(tuple => tuple.Item1 == sourceReturnType && tuple.Item2 == targeReturnType)
                   != null;
        }

        //public static void PerformSmartCast(this IExpression left, IExpression right)
        //{
        //    if(left.ReturnType == right.ReturnType) return;
        //    if(!left.ReturnType.IsCastableTo(right.ReturnType))
        //        throw new ExpressionException($"Types {left.ReturnType} and {right.ReturnType} are not castable");
        //    right.CastToType = left.ReturnType;
        //}

        public static ReturnType GetResultReturnType(this IExpression expression)
        {
            return expression.CastToType != null 
                ? expression.CastToType
                : expression.ReturnType;
        }
    }
}