using System.Collections.Generic;
using System.Linq;

namespace JasminSharp
{
    public abstract class TwoArgumentInstruction : ITwoArgumentInstruction
    {
        public string Name { get; }
        public string FirstArgument { get; protected set; }
        public string SecondArgument { get; protected set; }

        protected TwoArgumentInstruction(string name)
        {
            Name = name;
        }

        public IEnumerable<string> GenerateListing()
        {
            return new List<string>()
            {
                $"{Name} {FirstArgument} {SecondArgument}"
            };
        }
    }

    public abstract class FieldInstruction : TwoArgumentInstruction
    {
        protected FieldInstruction(string name)
            : base(name)
        {
        }

        public FieldInstruction WithFieldName(string name)
        {
            FirstArgument = name;
            return this;
        }

        public FieldInstruction WithSignature(string signature)
        {
            SecondArgument = signature;
            return this;
        }
    }

    public sealed class GetFieldInstruction : FieldInstruction
    {
        public GetFieldInstruction()
            : base("getfield")
        {
        }
    }

    public sealed class PutFieldInstruction : FieldInstruction
    {
        public PutFieldInstruction() 
            : base("putfield")
        {
        }
    }
    
    public sealed class GetStaticInstruction : FieldInstruction
    {
        public GetStaticInstruction()
            : base("getstatic")
        {
        }
    }
    
    public sealed class PutStaticInstruction : FieldInstruction
    {
        public PutStaticInstruction()
            : base("putstatic")
        {
        }
    }
}