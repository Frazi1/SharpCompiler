using System;
using MathLang.CodeGeneration.JasminJava;
using MathLang.Tree.Nodes.Enums;

namespace MathLang.CodeGeneration.Helpers.Converters
{
    public static class ReturnTypeToStringConverter
    {
        public static string Convert(ReturnType returnType)
        {
            switch (returnType)
            {
                case BoolReturnType boolReturnType:
                    return JasminReferenceConstants.JavaBool;
                case CharReturnType charReturnType:
                    return JasminReferenceConstants.JavaChar;
                case ArrayReturnType arrayReturnType:
                    return $"{JasminReferenceConstants.ArrayMark}{Convert(arrayReturnType.InnerType)}";
                case IntReturnType intReturnType:
                    return JasminReferenceConstants.JavaInteger;
                case StringReturnType stringReturnType:
                    return JasminReferenceConstants.JavaStringClass;
                case VoidReturnType voidReturnType:
                    return JasminReferenceConstants.JavaVoid;
                default:
                    throw new InvalidOperationException($"Bad type {returnType} (Convert)");
            }
        }
    }
}