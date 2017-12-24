using JasminSharp.Helpers;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class JasminReferenceConstants
    {
        public const string JavaObjectClass = "Ljava/lang/Object;";
        public const string JavaIntegerClass = "jLava/lang/Integer;";
        public const string JavaVoidShort = "V";
        public const string JavaIntegerShort = "I";
        public const string JavaBoolShort = "Z";
        public const string JavaByteShort = "B";
        public const string JavaCharShort = "C";
        
        public const string JavaBooleanClass = "Ljava/lang/Boolean;";
        public const string JavaCharacterClass = "Ljava/lang/Character;";
        public const string JavaStringClass = "Ljava/lang/String;";

        public const char ArrayMark = '[';

        public const string JavaInt = "int";
        public const string JavaChar = "char";
        public const string JavaBool = "boolean";
        public const string JavaByte = "byte";


        //public static string IntegerValueOf(string parameterType) => $"{JavaIntegerClass}/valueOf(I){parameterType}";
    }
}