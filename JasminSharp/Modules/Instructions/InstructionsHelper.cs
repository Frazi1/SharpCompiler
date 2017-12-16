namespace MathLang.CodeGeneration.JasminJava
{
    public static class InstructionsHelper
    {
        public static bipushInstruction BipushInstruction => new bipushInstruction(); 
        public static invokestaticInstruction InvokestaticInstruction => new invokestaticInstruction();
        public static invokevirtualInstruction InvokevirtualInstruction => new invokevirtualInstruction();
        public static invokenonvirtualInstruction InvokenonvirtualInstruction => new invokenonvirtualInstruction();
        public static astoreInstruction AstoreInstruction => new astoreInstruction();
    }
}