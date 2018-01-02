namespace JasminSharp
{
    public sealed class invokenonvirtualInstruction : MethodInvocationInstruction
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

        public invokenonvirtualInstruction WithReturnType(string type)
        {
            ReturnTypeName = type;
            return this;
        }

        public invokenonvirtualInstruction WithParameterType(params string[] typeNames)
        {
            CallParametersTypes.AddRange(typeNames);
            return this;
        }
    }

    public sealed class invokestaticInstruction: MethodInvocationInstruction
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
        public invokestaticInstruction WithReturnType(string type)
        {
            ReturnTypeName = type;
            return this;
        }

        public invokestaticInstruction WithParameterType(params string[] typeNames)
        {
            CallParametersTypes.AddRange(typeNames);
            return this;
        }
    }

    public sealed class invokevirtualInstruction : MethodInvocationInstruction
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

        public invokevirtualInstruction WithReturnType(string type)
        {
            ReturnTypeName = type;
            return this;
        }

        public invokevirtualInstruction WithParameterType(params string[] typeNames)
        {
            CallParametersTypes.AddRange(typeNames);
            return this;
        }
    }
}