namespace JasminSharp
{
    public sealed class gotoInstruction : LabelInstruction
    {
        public gotoInstruction()
        {
            Name = "goto";
        }
    }

    public sealed class goto_wInstruction : LabelInstruction
    {
        public goto_wInstruction()
        {
            Name = "goto_w";
        }
    }

    public sealed class if_acmpeqInstruction : LabelInstruction
    {
        public if_acmpeqInstruction()
        {
            Name = "if_acmpeq";
        }
    }

    public sealed class if_acmpneInstruction : LabelInstruction
    {
        public if_acmpneInstruction()
        {
            Name = "if_acmpne";
        }
    }

    public sealed class if_icmpeqInstruction : LabelInstruction
    {
        public if_icmpeqInstruction()
        {
            Name = "if_icmpeq";
        }
    }

    public sealed class if_icmpgeInstruction : LabelInstruction
    {
        public if_icmpgeInstruction()
        {
            Name = "if_icmpge";
        }
    }

    public sealed class if_icmpgtInstruction : LabelInstruction
    {
        public if_icmpgtInstruction()
        {
            Name = "if_icmpgt";
        }
    }

    public sealed class if_icmpleInstruction : LabelInstruction
    {
        public if_icmpleInstruction()
        {
            Name = "if_icmple";
        }
    }

    public sealed class if_icmpltInstruction : LabelInstruction
    {
        public if_icmpltInstruction()
        {
            Name = "if_icmplt";
        }
    }

    public sealed class if_icmpneInstruction : LabelInstruction
    {
        public if_icmpneInstruction()
        {
            Name = "if_icmpne";
        }
    }

    public sealed class ifeqInstruction : LabelInstruction
    {
        public ifeqInstruction()
        {
            Name = "ifeq";
        }
    }

    public sealed class ifgeInstruction : LabelInstruction
    {
        public ifgeInstruction()
        {
            Name = "ifge";
        }
    }

    public sealed class ifgtInstruction : LabelInstruction
    {
        public ifgtInstruction()
        {
            Name = "ifgt";
        }
    }

    public sealed class ifleInstruction : LabelInstruction
    {
        public ifleInstruction()
        {
            Name = "ifle";
        }
    }

    public sealed class ifltInstruction : LabelInstruction
    {
        public ifltInstruction()
        {
            Name = "iflt";
        }
    }

    public sealed class ifneInstruction : LabelInstruction
    {
        public ifneInstruction()
        {
            Name = "ifne";
        }
    }

    public sealed class ifnonnullInstruction : LabelInstruction
    {
        public ifnonnullInstruction()
        {
            Name = "ifnonnull";
        }
    }

    public sealed class ifnullInstruction : LabelInstruction
    {
        public ifnullInstruction()
        {
            Name = "ifnull";
        }
    }

    public sealed class jsrInstruction : LabelInstruction
    {
        public jsrInstruction()
        {
            Name = "jsr";
        }
    }

    public sealed class jsr_wInstruction : LabelInstruction
    {
        public jsr_wInstruction()
        {
            Name = "jsr_w";
        }
    }
}