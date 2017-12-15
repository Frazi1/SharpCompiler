namespace MathLang.CodeGeneration.JasminJava
{
    public class bipushInstruction : IntArgumentInstruction
    {
        public bipushInstruction WithName(string name)
        {
            Name = name;
            return this;
        }

        public bipushInstruction WithArgument(int argument)
        {
            IntArgument = argument;
            return this;
        }
    }

    public class sipushInstruction : IntArgumentInstruction
    {
        public sipushInstruction WithName(string name)
        {
            Name = name;
            return this;
        }

        public sipushInstruction WithArgument(int argument)
        {
            IntArgument = argument;
            return this;
        }
    }
}