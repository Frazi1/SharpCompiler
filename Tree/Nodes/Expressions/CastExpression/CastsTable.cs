using System;
using System.Collections.Generic;
using MathLang.Tree.Nodes.Enums;

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

        public static void AddCastablePair(ReturnType first, ReturnType second)
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
    }
}