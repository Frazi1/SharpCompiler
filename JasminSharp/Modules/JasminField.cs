using System.Collections.Generic;
using System.Linq;
using JasminSharp.Helpers;
using MathLang.CodeGeneration;

namespace JasminSharp
{
    public class JasminField : IJasminModule
    {
        public string Name { get; private set; }
        public string Signature { get; private set; }
        public JasminModifier Modifier { get; private set; }
        public List<IInstruction> ValueInstructions { get; } = new List<IInstruction>();

        public bool IsInitialized => ValueInstructions.Any();
        public bool IsStatic => Modifier.HasFlag(JasminModifier.Static);

        public IEnumerable<string> GenerateListing()
        {
            var codeListing = new List<string>();

            var fieldDeclaration = $"{JasminDirectives.Field}";
            Modifier.GetFlags<JasminModifier>().ForEach(flag =>
            {
                fieldDeclaration += $" {flag.GetTextValue()}";
            });
            fieldDeclaration += $" {Name} {Signature}";
            codeListing.Add(fieldDeclaration);
            
            //TODO: Initialization
            //ValueInstructions
            //    .Select(instruction => instruction.GenerateListing())
            //    .ForEach(listing => _codeListing.AddRange(listing));
            //_codeListing.AddRange(Instructions.PutStaticInstruction
            //    .WithFieldName(Name)
            //    .WithSignature(Signature)
            //    .GenerateListing());
            return codeListing;
        }

        public JasminField WithName(string name)
        {
            Name = name;
            return this;
        }

        public JasminField WithSignature(string signature)
        {
            Signature = signature;
            return this;
        }

        public JasminField WithValue(IEnumerable<IInstruction> instructions)
        {
            ValueInstructions.Clear();
            ValueInstructions.AddRange(instructions);
            return this;
        }

        public JasminField WithModifier(JasminModifier modifier)
        {
            Modifier = modifier;
            return this;
        }
    }
}