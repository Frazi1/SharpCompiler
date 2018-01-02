using MathLang.Tree.Nodes.Enums;

namespace MathLang.Tree.Semantics
{
    public static class SemanticsRunner
    {
        public static void Run(Nodes.Program program)
        {
            AddLibraryClasses(program);
            program.PreProcess();
            program.Process();
            program.SetVariableIndexes(FunctionIndexingStrategy.United);
        }

        public static void AddLibraryClasses(Nodes.Program program)
        {
            program.ClassNodes.Add(new AttributeBuilder(program)
                .WithName("JavaRef")
                .WithParameter(ReturnType.String, "ReferencePath", 0)
                .Build());

            program.ClassNodes.Add(new AttributeBuilder(program)
                .WithName("DotNetRef")
                .WithParameter(ReturnType.String, "ReferencePath", 0)
                .Build());
        }
    }
}