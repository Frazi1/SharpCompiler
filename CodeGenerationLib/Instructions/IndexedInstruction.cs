using System.Collections.Generic;

namespace MathLang.CodeGeneration.JasminJava
{
    public abstract class IndexedInstruction : IIndexedInstruction
    {
        public string Name { get; protected set; }
        public int VarIndex { get; protected set; }


        public IEnumerable<string> GenerateListing()
        {
            var listing = new List<string> {$"{Name} {VarIndex}"};
            return listing;
        }
    }
}