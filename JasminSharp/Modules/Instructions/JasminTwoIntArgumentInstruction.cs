namespace JasminSharp
{
    public class iincInstruction : TwoIntArgumentInstruction
    {
        public iincInstruction WithName(string name)
        {
            Name = name;
            return this;
        }
    }
}