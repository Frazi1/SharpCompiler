using JasminSharp.Helpers;

namespace MathLang.CodeGeneration.Jasmin
{
    public enum JasminModifier
    {
        [TextValue(JasminModifiersConstants.Private)] Private,
        [TextValue(JasminModifiersConstants.Public)] Public,
        [TextValue(JasminModifiersConstants.Static)] Static,
        [TextValue(JasminModifiersConstants.Abstarct)] Abstract,
        [TextValue(JasminModifiersConstants.Final)] Final
    }
}