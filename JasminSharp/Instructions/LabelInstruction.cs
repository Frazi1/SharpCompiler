using System.Collections.Generic;

namespace JasminSharp
{
    public class LabelInstruction : ArgumentInstruction, ILabelInstruction
    {
        public LabelInstruction WithLabel(string name)
        {
            Argument = name;
            return this;
        }
    }

    public sealed class InsertLabelInstruction : LabelInstruction
    {

        public override IEnumerable<string> GenerateListing()
        {
            return new List<string>() { $"{Argument}:" };
        }
    }
}