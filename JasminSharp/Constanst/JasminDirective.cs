using JasminSharp.Helpers;

namespace MathLang.CodeGeneration.Jasmin
{
    public enum JasminDirective
    {
        [TextValue(JasminDirectivesConstants.Super)] Super,
        [TextValue(JasminDirectivesConstants.Class)] Class,
        [TextValue(JasminDirectivesConstants.Source)] Source,
        [TextValue(JasminDirectivesConstants.Method)] Method,
        [TextValue(JasminDirectivesConstants.EndMethod)] EndMethod
    }
}