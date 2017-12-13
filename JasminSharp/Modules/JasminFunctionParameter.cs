namespace MathLang.CodeGeneration.Jasmin
{
    public class JasminFunctionParameter
    {
        public string Name { get; }
        public JasminType JasminType { get; }

        public JasminFunctionParameter(JasminType jasminType, string name)
        {
            Name = name;
            JasminType = jasminType;
        }
    }
}