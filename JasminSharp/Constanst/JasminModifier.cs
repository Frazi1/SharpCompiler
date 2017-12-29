using System;
using JasminSharp.Helpers;

namespace JasminSharp
{
    [Flags]
    public enum JasminModifier
    {
        [TextValue(JasminModifiersConstants.Private)] Private = 1,
        [TextValue(JasminModifiersConstants.Public)] Public = 2,
        [TextValue(JasminModifiersConstants.Static)] Static = 4,
        [TextValue(JasminModifiersConstants.Abstarct)] Abstract = 8,
        [TextValue(JasminModifiersConstants.Final)] Final = 16
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