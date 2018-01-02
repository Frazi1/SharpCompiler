using System.Collections.Generic;
using MathLang.Tree.Nodes.Enums;

namespace MathLang.Tree.Nodes.Expressions
{
    public static class MathematicalComparisonTable
    {
        private static List<ReturnType> CastsList { get; } =
            new List<ReturnType>();

        static MathematicalComparisonTable()
        {
            AddType(ReturnType.Char);
            AddType(ReturnType.Int);
        }

        public static void AddType(ReturnType returnType)
        {
            CastsList.Add(returnType);
        }

        public static bool IsMathematicallyComparisonable(this ReturnType returnType)
        {
            return CastsList.Contains(returnType);
        }
    }
}