using System.Collections.Generic;

namespace MathLang.CodeGeneration.JasminJava
{
    public interface IJasminModule
    {
        string Name { get; }
        IEnumerable<string> GenerateListing();
    }
}