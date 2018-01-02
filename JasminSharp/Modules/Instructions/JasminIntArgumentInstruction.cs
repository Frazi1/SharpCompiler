namespace JasminSharp
{
    namespace MathLang.CodeGeneration.JasminJava
    {
        public class bipushInstruction : IntArgumentInstruction
        {
            public bipushInstruction()
            {
                Name = "bipush";
            }

            public bipushInstruction WithArgument(int argument)
            {
                IntArgument = argument;
                return this;
            }
        }

        public class sipushInstruction : IntArgumentInstruction
        {
            public sipushInstruction()
            {
                Name = "sipush";
            }

            public sipushInstruction WithArgument(int argument)
            {
                IntArgument = argument;
                return this;
            }
        }
    }
}