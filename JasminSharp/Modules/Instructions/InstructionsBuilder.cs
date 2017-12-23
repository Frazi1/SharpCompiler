using System.Collections.Generic;
using static MathLang.CodeGeneration.JasminJava.Instructions;

namespace MathLang.CodeGeneration.JasminJava
{
    public static class InstructionsBuilder
    {
        private static int _count;


        public static IEnumerable<IInstruction> BuildLogicalAnd(IEnumerable<IInstruction> leftOperandInstructions,
            IEnumerable<IInstruction> rightOperandInstructions)
        {
            int currentCount = _count++;
            List<IInstruction> instructions = new List<IInstruction>();
            var ifeqInstruction = IfeqInstruction;
            string labelEnd = $"AndCodeGeneration_{currentCount}_end";
            string labelFalse = $"AndCodeGeneration_{currentCount}_false";

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

        public static IEnumerable<IInstruction> BuildLogicalOr(IEnumerable<IInstruction> leftOperandInstructions,
            IEnumerable<IInstruction> rightOperandInstructions)
        {
            int currentCount = _count++;
            List<IInstruction> instructions = new List<IInstruction>();
            string labelEnd = $"OrCodeGeneration_{currentCount}_end";
            string labelFalse = $"OrCodeGeneration_{currentCount}_false";
            string labelTrue = $"OrCodeGeneration_{currentCount}_true";

            instructions.AddRange(leftOperandInstructions);
            instructions.Add(IfneInstruction.WithLabel(labelTrue));
            instructions.AddRange(rightOperandInstructions);
            instructions.Add(IfeqInstruction.WithLabel(labelFalse));
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelTrue));
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