using System.Collections.Generic;

namespace JasminSharp
{
    public abstract class TwoIntArgumentInstruction : ITwoIntArgumentInstruction
    {

        public int IntFirstArgument { get; protected set; }

        public int IntSecondArgument { get; protected set; }

        public string Name { get; protected set; }

        public IEnumerable<string> GenerateListing()
        {
            var listing = new List<string> {$"{Name} {IntFirstArgument} {IntSecondArgument}"};
            return listing;
        }

        string ITwoArgumentInstruction.FirstArgument => IntFirstArgument.ToString();

        string ITwoArgumentInstruction.SecondArgument => IntSecondArgument.ToString();

        int ITwoIntArgumentInstruction.SecondArgument => IntSecondArgument;

        int ITwoIntArgumentInstruction.FirstArgument => IntFirstArgument;
    }
}