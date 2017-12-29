using System.Collections.Generic;
using System.Linq;
using JasminSharp.Helpers;
using MathLang.CodeGeneration;

namespace JasminSharp
{
    public class JasminStaticVariable : IJasminModule
    {
        private readonly List<string> _codeListing = new List<string>();

        public string Name { get; set; }
        public string Signature { get; private set; }
        public List<IInstruction> ValueInstructions { get; } = new List<IInstruction>();

        public IEnumerable<string> GenerateListing()
        {
            ValueInstructions
                .Select(instruction => instruction.GenerateListing())
                .ForEach(listing => _codeListing.AddRange(listing));
            _codeListing.AddRange(Instructions.PutStaticInstruction
                .WithFieldName(Name)
                .WithSignature(Signature)
                .GenerateListing());
            return _codeListing;
        }

        public JasminStaticVariable WithName(string name)
        {
            Name = name;
            return this;
        }

        public JasminStaticVariable WithSignature(string signature)
        {
            Signature = signature;
            return this;
        }

        public JasminStaticVariable WithValue(IEnumerable<IInstruction> instructions)
        {
            ValueInstructions.Clear();
            ValueInstructions.AddRange(instructions);
            return this;
        }
    }
}