using System.Collections.Generic;

namespace MathLang.CodeGeneration.Jasmin
{
    public interface IJasminModule
    {
        IEnumerable<string> GenerateListing();
    }
}