namespace MathLang.CodeGeneration.JasminJava
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