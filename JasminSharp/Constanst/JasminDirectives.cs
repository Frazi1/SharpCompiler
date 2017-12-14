using JasminSharp.Helpers;
using static MathLang.CodeGeneration.JasminJava.JasminDirectivesConstants;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class JasminDirectivesConstants
    {
        internal const string Super = ".super";
        internal const string Class = ".class";
        internal const string Source = ".source";
        internal const string Method = ".method";
        internal const string EndMethod = ".end method";


        internal const string VirtualMark = "V";
    }

    public enum JasminDirective
    {
        [TextValue(JasminDirectivesConstants.Super)] Super,
        [TextValue(JasminDirectivesConstants.Class)] Class,
        [TextValue(JasminDirectivesConstants.Source)] Source,
        [TextValue(JasminDirectivesConstants.Method)] Method,
        [TextValue(JasminDirectivesConstants.EndMethod)] EndMethod
    }
}