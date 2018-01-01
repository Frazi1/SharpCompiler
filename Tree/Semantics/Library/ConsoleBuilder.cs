using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;

namespace MathLang.Tree.Semantics
{
//    public class ConsoleBuilder
//    {
//        private readonly Nodes.Program _program;
//
//        public ConsoleBuilder(Nodes.Program program)
//        {
//            _program = program;
//        }
//
//        public ClassDeclaration Build()
//        {
//            var console = LibraryClasses.BuildClassDeclaration(_program, "Console");
//            console.IsStatic = true;
//            var writeLineBool = LibraryClasses.BuildFunctionDeclaration(console, "WriteLineBool", ReturnType.Void,
//                ("input", ReturnType.Bool));
//
//            var writeLineChar = LibraryClasses.BuildFunctionDeclaration(console, "WriteLineChar", ReturnType.Void,
//                ("input", ReturnType.Char));
//
//            var writeLineInt = LibraryClasses.BuildFunctionDeclaration(console, "WriteLineInt", ReturnType.Void,
//                ("input", ReturnType.Int));
//
//            var readChar = LibraryClasses.BuildFunctionDeclaration(console, "ReadChar", ReturnType.Char);
//
//            console.FunctionDeclarationNodes.AddRange(new[] {writeLineInt, writeLineBool, writeLineChar, readChar});
//            return console;
//        }
//    }
}