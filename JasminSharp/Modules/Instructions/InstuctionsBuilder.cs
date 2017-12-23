using System.Collections.Generic;
using static MathLang.CodeGeneration.JasminJava.Instructions;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class InstuctionsBuilder
    {
        private static int _count;
        public static IEnumerable<IInstruction> BuildIfGreater()
        {
            return BuildCompareInstrution(If_icmpgtInstruction);

        }

        public static IEnumerable<IInstruction> BuildCompareInstrution(LabelInstruction compareInstruction)
        {
            string labelEnd = $"{compareInstruction.Name}_{_count}_end";
            string labelTrue = $"{compareInstruction.Name}_{_count}_true";
            _count++;
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.Add(compareInstruction.WithLabel(labelTrue));
            instructions.Add(Iconst_0Instruction);
            instructions.Add(GotoInstruction.WithLabel(labelEnd));
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelTrue));
            instructions.Add(Iconst_1Instruction);
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelEnd));
            return instructions;
        }
    }
}