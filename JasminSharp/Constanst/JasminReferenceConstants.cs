namespace JasminSharp
{
    public static class JasminReferenceConstants
    {
        public const char ArrayMark = '[';
        public const string JavaVoidPrimitive = "V";
        public const string JavaIntegerPrimitive = "I";
        public const string JavaBooleanPrimitive = "Z";
        public const string JavaBytePrimitive = "B";
        public const string JavaCharPrimitive = "C";

        public const string JavaIntKeyword = "int";
        public const string JavaCharKeyword = "char";
        public const string JavaBooleanKeyword = "boolean";
        public const string JavaByteKeyword = "byte";

        public const string JavaBooleanClassShort = "java/lang/Boolean";
        public const string JavaObjectClassShort = "java/lang/Object";
        public const string JavaIntegerClassShort = "java/lang/Integer";
        public const string JavaStringClassShort = "java/lang/String";
        public const string JavaCharacterClassShort = "java/lang/Character";

        public const string JavaObjectClassFull = "L" + JavaObjectClassShort + ";";
        public const string JavaBooleanClassFull = "L" + JavaBooleanClassShort + ";";
        public const string JavaIntegerClassFull = "L" + JavaIntegerClassShort + ";";
        public const string JavaStringClassFull = "L" + JavaStringClassShort + ";";
        public const string JavaCharacterClassFull = "L" + JavaCharacterClassShort + ";";

        public const string MethodClInit = "<clinit>";
        public const string MethodInit = "<init>";
        
    }
}