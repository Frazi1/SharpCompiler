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
//            var writeLineBool = LibraryClasses.BuildFunctionDeclaration(console, "WriteLineBool", TypeDefinition.Void,
//                ("input", TypeDefinition.Bool));
//
//            var writeLineChar = LibraryClasses.BuildFunctionDeclaration(console, "WriteLineChar", TypeDefinition.Void,
//                ("input", TypeDefinition.Char));
//
//            var writeLineInt = LibraryClasses.BuildFunctionDeclaration(console, "WriteLineInt", TypeDefinition.Void,
//                ("input", TypeDefinition.Int));
//
//            var readChar = LibraryClasses.BuildFunctionDeclaration(console, "ReadChar", TypeDefinition.Char);
//
//            console.FunctionDeclarationNodes.AddRange(new[] {writeLineInt, writeLineBool, writeLineChar, readChar});
//            return console;
//        }
//    }
}