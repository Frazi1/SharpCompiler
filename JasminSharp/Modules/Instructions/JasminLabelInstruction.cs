using MathLang.CodeGeneration.JasminJava;

public sealed class gotoInstruction : LabelInstruction
{
    public gotoInstruction()
    {
        Name = "goto";
    }
    public gotoInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class goto_wInstruction : LabelInstruction
{
    public goto_wInstruction()
    {
        Name = "goto_w";
    }
    public goto_wInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class if_acmpeqInstruction : LabelInstruction
{
    public if_acmpeqInstruction()
    {
        Name = "if_acmpeq";
    }
    public if_acmpeqInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class if_acmpneInstruction : LabelInstruction
{
    public if_acmpneInstruction()
    {
        Name = "if_acmpne";
    }
    public if_acmpneInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class if_icmpeqInstruction : LabelInstruction
{
    public if_icmpeqInstruction()
    {
        Name = "if_icmpeq";
    }
    public if_icmpeqInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class if_icmpgeInstruction : LabelInstruction
{
    public if_icmpgeInstruction()
    {
        Name = "if_icmpge";
    }
    public if_icmpgeInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class if_icmpgtInstruction : LabelInstruction
{
    public if_icmpgtInstruction()
    {
        Name = "if_icmpgt";
    }
    public if_icmpgtInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class if_icmpleInstruction : LabelInstruction
{
    public if_icmpleInstruction()
    {
        Name = "if_icmple";
    }
    public if_icmpleInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class if_icmpltInstruction : LabelInstruction
{
    public if_icmpltInstruction()
    {
        Name = "if_icmplt";
    }
    public if_icmpltInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class if_icmpneInstruction : LabelInstruction
{
    public if_icmpneInstruction()
    {
        Name = "if_icmpne";
    }
    public if_icmpneInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class ifeqInstruction : LabelInstruction
{
    public ifeqInstruction()
    {
        Name = "ifeq";
    }
    public ifeqInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class ifgeInstruction : LabelInstruction
{
    public ifgeInstruction()
    {
        Name = "ifge";
    }
    public ifgeInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class ifgtInstruction : LabelInstruction
{
    public ifgtInstruction()
    {
        Name = "ifgt";
    }
    public ifgtInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class ifleInstruction : LabelInstruction
{
    public ifleInstruction()
    {
        Name = "ifle";
    }
    public ifleInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class ifltInstruction : LabelInstruction
{
    public ifltInstruction()
    {
        Name = "iflt";
    }
    public ifltInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class ifneInstruction : LabelInstruction
{
    public ifneInstruction()
    {
        Name = "ifne";
    }
    public ifneInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class ifnonnullInstruction : LabelInstruction
{
    public ifnonnullInstruction()
    {
        Name = "ifnonnull";
    }
    public ifnonnullInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class ifnullInstruction : LabelInstruction
{
    public ifnullInstruction()
    {
        Name = "ifnull";
    }
    public ifnullInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class jsrInstruction : LabelInstruction
{
    public jsrInstruction()
    {
        Name = "jsr";
    }
    public jsrInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
public sealed class jsr_wInstruction : LabelInstruction
{
    public jsr_wInstruction()
    {
        Name = "jsr_w";
    }
    public jsr_wInstruction WithLabel(string label)
    {
        Argument = label;
        return this;
    }
}
