using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstuctionsCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
        }

        static void First()
        {
            var list = File.ReadAllLines(@"..\..\VariablesCommands.txt");
            List<string> result = new List<string>();
            foreach (string varCommand in list)
            {
                result.AddRange(GenerateVarCommandClass(varCommand));
            }
            File.WriteAllLines("varCommands.txt", result);
        }

        private static IEnumerable<string> GenerateVarCommandClass(string varCommand)
        {
            var splitted = varCommand.Split(' ');
            string name = splitted[0];
            return GeneratePublicInstructionClass(name);

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
    }
}
