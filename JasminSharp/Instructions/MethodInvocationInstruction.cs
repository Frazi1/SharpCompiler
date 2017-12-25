using System.Collections.Generic;

namespace JasminSharp
{
    public class MethodInvocationInstruction : ArgumentInstruction
    {
        public string ReturnTypeName { get; protected set; }
        public List<string> CallParametersTypes { get; } = new List<string>();

        public override IEnumerable<string> GenerateListing()
        {
            var listing = new List<string>
            {
                $"{Name} {Argument}({string.Join("", CallParametersTypes)}){ReturnTypeName}"
            };
            return listing;
        }
    }
}