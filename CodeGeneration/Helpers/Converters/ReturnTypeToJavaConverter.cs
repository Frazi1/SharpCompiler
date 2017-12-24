using System;
using MathLang.CodeGeneration.JasminJava;
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
        
        public static string ConvertToJasminRepresentation(this ReturnType returnType)
        {
            switch (returnType)
            {
                case BoolReturnType boolReturnType:
                    return JasminReferenceConstants.JavaBoolShort;
                case CharReturnType charReturnType:
                    return JasminReferenceConstants.JavaCharShort;
                case ArrayReturnType arrayReturnType:
                    return $"{JasminReferenceConstants.ArrayMark}{ConvertToJasminRepresentation(arrayReturnType.InnerType)}";
                case IntReturnType intReturnType:
                    return JasminReferenceConstants.JavaIntegerShort;
                case StringReturnType stringReturnType:
                    return JasminReferenceConstants.JavaStringClass;
                case VoidReturnType voidReturnType:
                    return JasminReferenceConstants.JavaVoidShort;
                default:
                    throw new InvalidOperationException($"Bad type {returnType} (Convert)");
            }
        }

        public static string ConvertToJavaRepresentation(this ReturnType returnType)
        {
            switch (returnType)
            {
                case BoolReturnType boolReturnType:
                    return JasminReferenceConstants.JavaBool;
                case CharReturnType charReturnType:
                    return JasminReferenceConstants.JavaChar;
                case ArrayReturnType arrayReturnType:
                    return $"{JasminReferenceConstants.ArrayMark}{ConvertToJavaRepresentation(arrayReturnType.InnerType)}";
                case IntReturnType intReturnType:
                    return JasminReferenceConstants.JavaInt;
                case StringReturnType stringReturnType:
                    return JasminReferenceConstants.JavaStringClass;
                case VoidReturnType voidReturnType:
                    return JasminReferenceConstants.JavaVoidShort;
                default:
                    throw new InvalidOperationException($"Bad type {returnType} (Convert)");
            }
        }
    }
}