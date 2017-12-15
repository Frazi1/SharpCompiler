using System.Collections.Generic;

namespace MathLang.CodeGeneration.JasminJava
{
    public interface IInstruction
    {
        string Name { get; }
        IEnumerable<string> GenerateListing();
    }
}