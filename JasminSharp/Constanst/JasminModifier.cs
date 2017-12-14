using JasminSharp.Helpers;

namespace MathLang.CodeGeneration.JasminJava
{
    public enum JasminModifier
    {
        [TextValue(JasminModifiersConstants.Private)] Private,
        [TextValue(JasminModifiersConstants.Public)] Public,
        [TextValue(JasminModifiersConstants.Static)] Static,
        [TextValue(JasminModifiersConstants.Abstarct)] Abstract,
        [TextValue(JasminModifiersConstants.Final)] Final
    }

    internal static class JasminModifiersConstants
    {
        internal const string Public = "public";
        internal const string Private = "public";
        internal const string Final = "final";
        internal const string Abstarct = "public";
        internal const string Static = "static";

    }
}