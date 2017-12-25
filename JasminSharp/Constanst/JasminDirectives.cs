namespace JasminSharp
{
    public static class JasminDirectives
    {
        internal const string Super = ".super";
        internal const string Class = ".class";
        internal const string Source = ".source";
        internal const string Method = ".method";
        internal const string EndMethod = ".end method";
        public const string LimitLocals = ".limit locals";
        public const string LimitStack = ".limit stack";

        public static string LimitStackTo(int number) => $"{LimitStack} {number}";
        public static string LimitLocalsTo(int number) => $"{LimitLocals} {number}";
    }
}