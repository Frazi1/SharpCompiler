using System.Collections.Generic;

namespace MathLang.CodeGeneration.Jasmin
{
    public interface IJasminModule
    {
        string Name { get; }
        IEnumerable<string> GenerateListing();
    }
}