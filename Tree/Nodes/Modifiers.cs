using System.Collections.Generic;

namespace MathLang.Tree.Nodes
{
    public static class Modifiers
    {
        public const string Static = "static";
        public const string Extern = "extern";
        
        public static IEnumerable<string> All = new List<string>{Static, Extern};
    }

    public enum Modifier
    {
        None,
        Static,
        Extern
    }
}