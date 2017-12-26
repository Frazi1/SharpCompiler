using System.Collections.Generic;

namespace MathLang.CodeGeneration.JasminJava
{
    public interface IListingGenerator
    {
        IEnumerable<string> GenerateListing();
    }
}