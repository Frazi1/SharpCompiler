using JasminSharp.Helpers;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class JasminReferenceConstants
    {
        public const string JavaObject = "Ljava/lang/Object;";
        public const string JavaIntegerClass = "jLava/lang/Integer;";
        public const string JavaVoid = "V";
        public const string JavaInteger = "I";
        public const string JavaBool = "Z";
        public const string JavaByte = "B";
        public const string JavaBooleanClass = "Ljava/lang/Boolean;";
        public const string JavaChar = "Ljava/lang/Character;";

        public const char ArrayMark = '[';

        public static string IntegerValueOf(string parameterType) => $"{JavaIntegerClass}/valueOf(I){parameterType}";
    }
}