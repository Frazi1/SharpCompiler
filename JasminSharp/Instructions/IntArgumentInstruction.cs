using System.Collections.Generic;

namespace JasminSharp
{
    public abstract class IntArgumentInstruction : IIntArgumentInstruction
    {
        private string _argument;
        private int _intArgument;

        public int IntArgument
        {
            get => _intArgument;
            protected set
            {
                _intArgument = value;
                _argument = value.ToString();
            }
        }

        public string Name { get; protected set; }


        public IEnumerable<string> GenerateListing()
        {
            var listing = new List<string> {$"{Name} {IntArgument}"};
            return listing;
        }

        string IArgumentInstruction.Argument
        {
            get { return _argument; }
        }

        int IIntArgumentInstruction.Argument
        {
            get { return IntArgument; }
        }
    }
}