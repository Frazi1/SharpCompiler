using System;
using JasminSharp;
using MathLang.Tree.Nodes.Enums;

namespace MathLang.CodeGeneration.Helpers.Converters
{
    public static class ReturnTypeToJavaConverter
    {
        public static bool IsPrimitiveType(this TypeDefinition typeDefinition)
        {
            if (typeDefinition == TypeDefinition.Bool
                || typeDefinition == TypeDefinition.Char
                || typeDefinition == TypeDefinition.Int)
                return true;
            return false;
        }

        public static bool IsReferenctType(this TypeDefinition typeDefinition)
        {
            return !typeDefinition.IsPrimitiveType();
        }
        
        public static string ConvertToFullRepresentation(this TypeDefinition typeDefinition)
        {
            switch (typeDefinition)
            {
                case BoolTypeDefinition boolReturnType:
                    return JasminReferenceConstants.JavaBooleanPrimitive;
                case CharTypeDefinition charReturnType:
                    return JasminReferenceConstants.JavaCharPrimitive;
                case ArrayTypeDefinition arrayReturnType:
                    return $"{JasminReferenceConstants.ArrayMark}{ConvertToFullRepresentation(arrayReturnType.InnerTypeDefinition)}";
                case IntTypeDefinition intReturnType:
                    return JasminReferenceConstants.JavaIntegerPrimitive;
                case StringTypeDefinition stringReturnType:
                    return JasminReferenceConstants.JavaStringClassFull;
                case VoidTypeDefinition voidReturnType:
                    return JasminReferenceConstants.JavaVoidPrimitive;
                default:
                    throw new InvalidOperationException($"Bad type {typeDefinition} (Convert)");
            }
        }

        public static string ConvertToKeywordRepresentation(this TypeDefinition typeDefinition)
        {
            switch (typeDefinition)
            {
                case BoolTypeDefinition boolReturnType:
                    return JasminReferenceConstants.JavaBooleanKeyword;
                case CharTypeDefinition charReturnType:
                    return JasminReferenceConstants.JavaCharKeyword;
                case ArrayTypeDefinition arrayReturnType:
                    return $"{JasminReferenceConstants.ArrayMark}{ConvertToKeywordRepresentation(arrayReturnType.InnerTypeDefinition)}";
                case IntTypeDefinition intReturnType:
                    return JasminReferenceConstants.JavaIntKeyword;
                case StringTypeDefinition stringReturnType:
                    return JasminReferenceConstants.JavaStringClassShort;
                case VoidTypeDefinition voidReturnType:
                    return JasminReferenceConstants.JavaVoidPrimitive;
                default:
                    throw new InvalidOperationException($"Bad type {typeDefinition} (Convert)");
            }
        }
        
    }
}