using System;
using System.Collections.Generic;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Interfaces;

namespace MathLang.Tree.Nodes.Expressions
{
    public static class CastsTable
    {
        private static List<Tuple<TypeDefinition, TypeDefinition>> CastsList { get; } =
            new List<Tuple<TypeDefinition, TypeDefinition>>();

        static CastsTable()
        {
            AddCastablePair(TypeDefinition.Char, TypeDefinition.Int);
        }

        private static void AddCastablePair(TypeDefinition first, TypeDefinition second)
        {
            CastsList.Add(new Tuple<TypeDefinition, TypeDefinition>(first, second));
            //CastsList.Add(new Tuple<TypeDefinition, TypeDefinition>(second, first));
        }

        public static bool IsCastableTo(this TypeDefinition sourceTypeDefinition, TypeDefinition targeTypeDefinition)
        {
            return CastsList
                       .Find(tuple => tuple.Item1 == sourceTypeDefinition && tuple.Item2 == targeTypeDefinition)
                   != null;
        }

        //public static void PerformSmartCast(this IExpression left, IExpression right)
        //{
        //    if(left.TypeDefinition == right.TypeDefinition) return;
        //    if(!left.TypeDefinition.IsCastableTo(right.TypeDefinition))
        //        throw new ExpressionException($"Types {left.TypeDefinition} and {right.TypeDefinition} are not castable");
        //    right.CastToType = left.TypeDefinition;
        //}

        public static TypeDefinition GetResultReturnType(this IExpression expression)
        {
            return expression.CastToType != null 
                ? expression.CastToType
                : expression.TypeDefinition;
        }
    }
}