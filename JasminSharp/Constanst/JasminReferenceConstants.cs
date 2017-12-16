using JasminSharp.Helpers;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class JasminReferenceConstants
    {
        public const string JavaObject = "java/lang/Object";
        public const string JavaInteger = "java/lang/Integer";
        public const string JavaVoid = "V";
        public const string JavaBoolean = "java/lang/Boolean";
        public const string JavaChar = "java/lang/Character";

        public const char ArrayMark = '[';

        public static string IntegerValueOf(string parameterType) => $"{JavaInteger}/valueOf(I){parameterType}";
    }
}