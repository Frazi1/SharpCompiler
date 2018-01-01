using System;
using System.Collections.Generic;

namespace MathLang.Tree.Nodes
{
    public static class Modifiers
    {
        public const string Static = "static";
        public const string Extern = "extern";
        public const string Protected = "protected";
        public const string Private = "private";
        public const string Public = "public";
        
        public static IEnumerable<string> All = new List<string>{Static, Extern};
    }

    [Flags]
    public enum Modifier
    {
        None = 0,
        Private = 1,
        Static = 2,
        Extern = 4,
        Public = 8,
        Protected = 16
    }
}