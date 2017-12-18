namespace MathLang.CodeGeneration.JasminJava
{
    public sealed class ldcInstruction : ArgumentInstruction
    {
        public ldcInstruction()
        {
            Name = "ldc";
        }

        /// <summary>
        /// Value can be of type string, integer ...
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ldcInstruction WithValue(string value)
        {
            Argument = value;
            return this;
        }
    }

    public sealed class ldc_wInstruction : ArgumentInstruction
    {
        public ldc_wInstruction()
        {
            Name = "ldc_w";
        }

        /// <summary>
        /// Value can be of type string, integer ...
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ldc_wInstruction WithValue(string value)
        {
            Argument = value;
            return this;
        }
    }
}