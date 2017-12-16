using MathLang.CodeGeneration.JasminJava;

public sealed class retInstruction : IndexedInstruction
{
    public retInstruction()
    {
        Name = "ret";
    }
    public retInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
public sealed class aloadInstruction : IndexedInstruction
{
    public aloadInstruction()
    {
        Name = "aload";
    }
    public aloadInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
public sealed class astoreInstruction : IndexedInstruction
{
    public astoreInstruction()
    {
        Name = "astore";
    }
    public astoreInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
public sealed class dloadInstruction : IndexedInstruction
{
    public dloadInstruction()
    {
        Name = "dload";
    }
    public dloadInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
public sealed class dstoreInstruction : IndexedInstruction
{
    public dstoreInstruction()
    {
        Name = "dstore";
    }
    public dstoreInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
public sealed class floadInstruction : IndexedInstruction
{
    public floadInstruction()
    {
        Name = "fload";
    }
    public floadInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
public sealed class fstoreInstruction : IndexedInstruction
{
    public fstoreInstruction()
    {
        Name = "fstore";
    }
    public fstoreInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
public sealed class iloadInstruction : IndexedInstruction
{
    public iloadInstruction()
    {
        Name = "iload";
    }
    public iloadInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
public sealed class istoreInstruction : IndexedInstruction
{
    public istoreInstruction()
    {
        Name = "istore";
    }
    public istoreInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
public sealed class lloadInstruction : IndexedInstruction
{
    public lloadInstruction()
    {
        Name = "lload";
    }
    public lloadInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
public sealed class lstoreInstruction : IndexedInstruction
{
    public lstoreInstruction()
    {
        Name = "lstore";
    }
    public lstoreInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}
