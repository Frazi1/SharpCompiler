namespace MathLang.CodeGeneration.JasminJava
{
    public sealed class invokenonvirtualInstruction : ArgumentInstruction
    {
        public invokenonvirtualInstruction()
        {
            Name = "invokenonvirtual";
        }
        
        public invokenonvirtualInstruction WithMethodFullName(string name)
        {
            Argument = name;
            return this;
        }
    }

    public sealed class invokestaticInstruction: ArgumentInstruction
    {
        public invokestaticInstruction()
        {
            Name = "invokestatic";
        }
        
        public invokestaticInstruction WithMethodFullName(string name)
        {
            Argument = name;
            return this;
        }
    }

    public sealed class invokevirtualInstruction : ArgumentInstruction
    {
        public invokevirtualInstruction()
        {
            Name = "invokevirtual";
        }
        
        public invokevirtualInstruction WithMethodFullName(string name)
        {
            Argument = name;
            return this;
        }
    }
}