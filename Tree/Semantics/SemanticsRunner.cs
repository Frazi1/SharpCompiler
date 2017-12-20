namespace MathLang.Tree.Semantics
{
    public static class SemanticsRunner
    {
        public static void Run(Nodes.Program program)
        {
            AddLibraryClasses(program);
            program.PreProcess();
            program.Process();
            program.SetVariableIndexes();
        }

        public static void AddLibraryClasses(Nodes.Program program)
        {
            //var consoleBuilder = new ConsoleBuilder(program);
            //program.ClassNodes.Add(consoleBuilder.Build());
            var javaRefAttrBuilder = new JavaRefAttributeBuilder(program); 
            program.ClassNodes.Add(javaRefAttrBuilder.Build());
        }
    }
}