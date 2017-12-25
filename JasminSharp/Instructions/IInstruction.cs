using MathLang.CodeGeneration.JasminJava;

namespace JasminSharp
{
    public interface IInstruction : IListingGenerator
    {
        string Name { get; }
    }

    public interface IIndexedInstruction : IInstruction
    {
        int VarIndex { get; }
    }

    public interface IArgumentInstruction : IInstruction
    {
        string Argument { get; }
    }

    public interface IIntArgumentInstruction : IArgumentInstruction
    {
        new int Argument { get; }
    }

    public interface ITwoArgumentInstruction : IInstruction
    {
        string FirstArgument { get; }
        string SecondArgument { get; }
    }

    public interface ITwoIntArgumentInstruction : ITwoArgumentInstruction
    {
        new int FirstArgument { get; }
        new int SecondArgument { get; }
    }
    public interface ILabelInstruction : IArgumentInstruction
    {
    }
}