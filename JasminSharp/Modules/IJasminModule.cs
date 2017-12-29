using MathLang.CodeGeneration.JasminJava;

namespace JasminSharp
{
    public interface IJasminModule : IListingGenerator
    {
        string Name { get; }
    }
}