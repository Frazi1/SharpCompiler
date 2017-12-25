using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InstuctionsCodeGenerator
{
    class Program
    {
        private static readonly List<string> InstuctionsList = new List<string>();
        static void Main(string[] args)
        {
            IndexedInstructions();
            BranchInstructions();
            NoArgInstructions();
            GenerateInstructionsGetters();
        }

        private static void GenerateInstructionsGetters()
        {
            File.WriteAllLines("Getters.txt", InstuctionsList.Select(className =>
            {
                string upperClassName = className[0].ToString().ToUpper() + className.Substring(1);
                return $"public static {className} {upperClassName}=> new {className}();";
            }));
        }

        private static void NoArgInstructions()
        {
            var list = File.ReadAllText(@"..\..\NoArgCommands.txt").Split(' ');
            List<string> result = new List<string>();
            foreach (string noArgCommand in list)
            {
                result.AddRange(GenerateNoArgInstructionClass(noArgCommand));
            }
            File.WriteAllLines("NoArgCommands.txt", result);
        }


        static void IndexedInstructions()
        {
            var list = File.ReadAllLines(@"..\..\VariablesCommands.txt");
            List<string> result = new List<string>();
            foreach (string varCommand in list)
            {
                result.AddRange(GenerateVarCommandClassV2(varCommand));
            }
            File.WriteAllLines("varCommands.txt", result);
        }
        static void BranchInstructions()
        {
            var list = File.ReadAllLines(@"..\..\branchCommands.txt");
            List<string> result = new List<string>();
            foreach (string branchCommand in list)
            {
                result.AddRange(GenerateBranchInstructionClass(branchCommand.Split(' ')[0]));
            }
            File.WriteAllLines("branchCommands.txt", result);
        }

        private static IEnumerable<string> GenerateVarCommandClass(string varCommand)
        {
            var splitted = varCommand.Split(' ');
            string name = splitted[0];
            return GeneratePublicInstructionClass(name);

        }

        private static IEnumerable<string> GenerateVarCommandClassV2(string varCommand)
        {
            var splitted = varCommand.Split(' ');
            string name = splitted[0];
            return GeneratePublicIndexedInstructionClass(name);

        }

        private static IEnumerable<string> GeneratePublicInstructionClass(string name)
        {
            List<string> result = new List<string>();
            result.Add($"public sealed class {name}Instruction : IJasminInstruction");
            result.Add("{");
            result.Add($"public string Name"+ "{get;} = " + $"\"{name}\";");
            result.Add("public int VarIndex {get;}");
            result.Add($"public {name}Instruction(int varIndex)");
            result.Add("{");
            result.Add("VarIndex = varIndex;");
            result.Add("}");
            result.Add("}");
            return result;
        }
        private static IEnumerable<string> GeneratePublicIndexedInstructionClass(string name)
        {
            string stringClass = name + "Instruction";
            InstuctionsList.Add(stringClass);
            List<string> result = new List<string>();
            result.Add($"public sealed class {stringClass} : IndexedInstruction");
            result.Add("{");
            result.Add($"public {stringClass}()");
            result.Add("{");
            result.Add($"Name = \"{name}\";");
            result.Add("}");
            result.Add($"public {stringClass} WithIndex(int index)");
            result.Add("{");
            result.Add("VarIndex = index;");
            result.Add("return this;");
            result.Add("}");

            result.Add("}");
            return result;
        }

        private static IEnumerable<string> GenerateBranchInstructionClass(string name)
        {
            string stringClass = name + "Instruction";
            InstuctionsList.Add(stringClass);
            List<string> result = new List<string>();
            result.Add($"public sealed class {stringClass} : LabelInstruction");
            result.Add("{");
            result.Add($"public {stringClass}()");
            result.Add("{");
            result.Add($"Name = \"{name}\";");
            result.Add("}");
            result.Add($"public {stringClass} WithLabel(string label)");
            result.Add("{");
            result.Add("Argument = label;");
            result.Add("return this;");
            result.Add("}");

            result.Add("}");
            return result;
        }

        private static IEnumerable<string> GenerateNoArgInstructionClass(string name)
        {
            string stringClass = name + "Instruction";
            InstuctionsList.Add(stringClass);
            List<string> result = new List<string>();
            result.Add($"public sealed class {stringClass} : NoArgumentInstruction");
            result.Add("{");
            result.Add($"public {stringClass}()");
            result.Add("{");
            result.Add($"Name = \"{name}\";");
            result.Add("}");
            result.Add("}");
            return result; 
        }
    }
}
