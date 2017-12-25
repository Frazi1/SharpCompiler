using System.Collections.Generic;
using MathLang.CodeGeneration;
using static MathLang.CodeGeneration.Instructions;

namespace JasminSharp
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

        public static IEnumerable<IInstruction> BuildLogicalNot(IEnumerable<IInstruction> operandInstructions)
        {
            int currentCount = _count++;
            List<IInstruction> instructions = new List<IInstruction>();
            string labelEnd = $"NotCodeGeneration_{currentCount}_end";
            string labelFalse = $"NotCodeGeneration_{currentCount}_false";

            instructions.AddRange(operandInstructions);
            instructions.Add(IfneInstruction.WithLabel(labelFalse));
            instructions.Add(Iconst_1Instruction);
            instructions.Add(GotoInstruction.WithLabel(labelEnd));
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelFalse));
            instructions.Add(Iconst_0Instruction);
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelEnd));
            return instructions;
        }

        public static IEnumerable<IInstruction> BuildIf(IEnumerable<IInstruction> conditionInstructions,
            IEnumerable<IInstruction> trueCondtionInstructions, IEnumerable<IInstruction> falseConditionInstructions)
        {
            int currentCount = _count++;
            List<IInstruction> instructions = new List<IInstruction>();
            string labelEnd = $"IfCodeGeneration_{currentCount}_end";
            string labelFalse = $"IfCodeGeneration_{currentCount}_false";
            string labelTrue = $"IfCodeGeneration_{currentCount}_true";
            instructions.AddRange(conditionInstructions);
            instructions.Add(IfeqInstruction.WithLabel(labelFalse));
            instructions.AddRange(trueCondtionInstructions);
            instructions.Add(GotoInstruction.WithLabel(labelEnd));
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelFalse));
            instructions.AddRange(falseConditionInstructions);
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelEnd));
            return instructions;
        }

        public static IEnumerable<IInstruction> BuildFor(IEnumerable<IInstruction> initializationInstructions,
            IEnumerable<IInstruction> bodyInstructions,
            IEnumerable<IInstruction> conditionInstructions,
            IEnumerable<IInstruction> iterationInstructions)
        {
            int currentCount = _count++;
            string labelEnd = $"ForCodeGeneration_{currentCount}_end";
            string labelStart = $"ForCodeGeneration_{currentCount}_start";
            string labelTrue = $"ForCodeGeneration_{currentCount}_true";
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.AddRange(initializationInstructions);
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelStart));
            instructions.AddRange(conditionInstructions);
            instructions.Add(IfeqInstruction.WithLabel(labelEnd));
            instructions.AddRange(bodyInstructions);
            instructions.AddRange(iterationInstructions);
            instructions.Add(GotoInstruction.WithLabel(labelStart));
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelEnd));
            return instructions;
        }

        public static IEnumerable<IInstruction> BuildWhile(IEnumerable<IInstruction> conditionInstructions,
            IEnumerable<IInstruction> bodyInstructions)
        {
            int currentCount = _count++;
            string labelEnd = $"WhileCodeGeneration_{currentCount}_end";
            string labelStart = $"WhileCodeGeneration_{currentCount}_start";
            List<IInstruction> instructions = new List<IInstruction>();
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelStart));
            instructions.AddRange(conditionInstructions);
            instructions.Add(IfeqInstruction.WithLabel(labelEnd));
            instructions.AddRange(bodyInstructions);
            instructions.Add(GotoInstruction.WithLabel(labelStart));
            instructions.Add(Instructions.InsertLabelInstruction.WithLabel(labelEnd));
            return instructions;
        }
    }
}