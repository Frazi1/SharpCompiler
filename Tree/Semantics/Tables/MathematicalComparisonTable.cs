using System.Collections.Generic;
using MathLang.Tree.Nodes.Enums;

namespace MathLang.Tree.Nodes.Expressions
{
    public static class MathematicalComparisonTable
    {
        private static List<TypeDefinition> CastsList { get; } =
            new List<TypeDefinition>();

        static MathematicalComparisonTable()
        {
            AddType(TypeDefinition.Char);
            AddType(TypeDefinition.Int);
        }

        public static void AddType(TypeDefinition typeDefinition)
        {
            CastsList.Add(typeDefinition);
        }

        public static bool IsMathematicallyComparisonable(this TypeDefinition typeDefinition)
        {
            return CastsList.Contains(typeDefinition);
        }
    }
}