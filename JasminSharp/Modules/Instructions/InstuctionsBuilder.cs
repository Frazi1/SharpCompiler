using System.Collections.Generic;
using static MathLang.CodeGeneration.JasminJava.Instructions;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class InstuctionsBuilder
    {
        private static int _count;


        public static IEnumerable<IInstruction> BuildLogicalAnd()
        {
            List<IInstruction> instructions = new List<IInstruction>();
            var compareInstruction = IfeqInstruction;
            string labelEnd = $"{compareInstruction.Name}_{_count}_end";
            string labelFalse = $"{compareInstruction.Name}_{_count}_false";

            instructions.Add(Iload_0Instruction);
            instructions.Add(compareInstruction.WithLabel(labelFalse));
            instructions.Add(Iload_1Instruction);
            instructions.Add(compareInstruction.WithLabel(labelFalse));


            _count++;
            return instructions;
        }

        public static IEnumerable<IInstruction> BuildCompareInstrution(IEnumerable<IInstruction> leftOperandInstructions,
            IEnumerable<IInstruction> rightOperandInstructions, LabelInstruction compareInstruction)
        {
            string labelEnd = $"{compareInstruction.Name}_{_count}_end";
            string labelTrue = $"{compareInstruction.Name}_{_count}_true";
            _count++;
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.AddRange(leftOperandInstructions);
            instructions.AddRange(rightOperandInstructions);
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