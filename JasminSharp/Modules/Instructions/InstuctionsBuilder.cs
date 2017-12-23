using System.Collections.Generic;
using static MathLang.CodeGeneration.JasminJava.Instructions;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class InstuctionsBuilder
    {
        private static int _count;


        public static IEnumerable<IInstruction> BuildLogicalAnd(IEnumerable<IInstruction> leftOperandInstructions,
            IEnumerable<IInstruction> rightOperandInstructions)
        {
            List<IInstruction> instructions = new List<IInstruction>();
            var ifeqInstruction = IfeqInstruction;
            string labelEnd = $"{ifeqInstruction.Name}_{_count}_end";
            string labelFalse = $"{ifeqInstruction.Name}_{_count}_false";
            _count++;

            instructions.AddRange(leftOperandInstructions);
            instructions.Add(ifeqInstruction.WithLabel(labelFalse));
            instructions.AddRange(rightOperandInstructions);
            instructions.Add(ifeqInstruction.WithLabel(labelFalse));
            instructions.Add(Iconst_1Instruction);
            instructions.Add(GotoInstruction.WithLabel(labelEnd));
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelFalse));
            instructions.Add(Iconst_0Instruction);
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelEnd));
            return instructions;
        }

        public static IEnumerable<IInstruction> BuildCompareInstrution(
            IEnumerable<IInstruction> leftOperandInstructions,
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