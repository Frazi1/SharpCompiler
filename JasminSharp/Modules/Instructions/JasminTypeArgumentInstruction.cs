namespace MathLang.CodeGeneration.JasminJava
{
    public class JasminTypeArgumentInstruction : ArgumentInstruction
    {
        public JasminTypeArgumentInstruction WithType(string type)
        {
            Argument = type;
            return this;
        }   
    }

    public sealed class NewArrayInstruction : JasminTypeArgumentInstruction
    {
        public NewArrayInstruction()
        {
            Name = "newarray";
        }
    }

    public sealed class ANewArrayInstruction : JasminTypeArgumentInstruction
    {
        public ANewArrayInstruction()
        {
            Name = "anewarray";
        }
    }
}