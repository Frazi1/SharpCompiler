using System;
using JasminSharp;
using MathLang.Tree.Nodes.Enums;

namespace MathLang.CodeGeneration.Helpers.Converters
{
    public static class ReturnTypeToJavaConverter
    {
        public static bool IsPrimitiveType(this ReturnType returnType)
        {
            if (returnType == ReturnType.Bool
                || returnType == ReturnType.Char
                || returnType == ReturnType.Int)
                return true;
            return false;
        }

        public static bool IsReferenctType(this ReturnType returnType)
        {
            return !returnType.IsPrimitiveType();
        }
        
        public static string ConvertToFullRepresentation(this ReturnType returnType)
        {
            switch (returnType)
            {
                case BoolReturnType boolReturnType:
                    return JasminReferenceConstants.JavaBooleanPrimitive;
                case CharReturnType charReturnType:
                    return JasminReferenceConstants.JavaCharPrimitive;
                case ArrayReturnType arrayReturnType:
                    return $"{JasminReferenceConstants.ArrayMark}{ConvertToFullRepresentation(arrayReturnType.InnerType)}";
                case IntReturnType intReturnType:
                    return JasminReferenceConstants.JavaIntegerPrimitive;
                case StringReturnType stringReturnType:
                    return JasminReferenceConstants.JavaStringClassFull;
                case VoidReturnType voidReturnType:
                    return JasminReferenceConstants.JavaVoidPrimitive;
                default:
                    throw new InvalidOperationException($"Bad type {returnType} (Convert)");
            }
        }

        public static string ConvertToKeywordRepresentation(this ReturnType returnType)
        {
            switch (returnType)
            {
                case BoolReturnType boolReturnType:
                    return JasminReferenceConstants.JavaBooleanKeyword;
                case CharReturnType charReturnType:
                    return JasminReferenceConstants.JavaCharKeyword;
                case ArrayReturnType arrayReturnType:
                    return $"{JasminReferenceConstants.ArrayMark}{ConvertToKeywordRepresentation(arrayReturnType.InnerType)}";
                case IntReturnType intReturnType:
                    return JasminReferenceConstants.JavaIntKeyword;
                case StringReturnType stringReturnType:
                    return JasminReferenceConstants.JavaStringClassShort;
                case VoidReturnType voidReturnType:
                    return JasminReferenceConstants.JavaVoidPrimitive;
                default:
                    throw new InvalidOperationException($"Bad type {returnType} (Convert)");
            }
        }
        
    }
}