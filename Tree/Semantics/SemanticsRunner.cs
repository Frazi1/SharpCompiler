namespace MathLang.Tree.Semantics
{
    public static class SemanticsRunner
    {
        public static void Run(Nodes.Program program)
        {
            program.PreProcess();
            program.Process();
        }
    }
}