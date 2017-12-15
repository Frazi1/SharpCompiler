namespace MathLang.CodeGeneration.JasminJava
{
    public interface IIndexedInstruction : IInstruction
    {
        int VarIndex { get; }
    }
}