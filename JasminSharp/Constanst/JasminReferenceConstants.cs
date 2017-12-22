using JasminSharp.Helpers;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class JasminReferenceConstants
    {
        public const string JavaObjectClass = "Ljava/lang/Object;";
        public const string JavaIntegerClass = "jLava/lang/Integer;";
        public const string JavaVoid = "V";
        public const string JavaInteger = "I";
        public const string JavaBool = "Z";
        public const string JavaByte = "B";
        public const string JavaChar = "C";
        
        public const string JavaBooleanClass = "Ljava/lang/Boolean;";
        public const string JavaCharacterClass = "Ljava/lang/Character;";
        public const string JavaStringClass = "Ljava/lang/String;";

        public const char ArrayMark = '[';

        //public static string IntegerValueOf(string parameterType) => $"{JavaIntegerClass}/valueOf(I){parameterType}";
    }
}