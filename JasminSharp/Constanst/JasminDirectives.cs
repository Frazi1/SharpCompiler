namespace JasminSharp
{
    public static class JasminDirectives
    {
        internal const string Super = ".super";
        internal const string Class = ".class";
        internal const string Source = ".source";
        internal const string Method = ".method";
        internal const string EndMethod = ".end method";
        internal const string Field = ".field";
        
        internal const string LimitLocals = ".limit locals";
        internal const string LimitStack = ".limit stack";

        internal static string LimitStackTo(int number) => $"{LimitStack} {number}";
        internal static string LimitLocalsTo(int number) => $"{LimitLocals} {number}";
    }
}