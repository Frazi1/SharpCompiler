using MathLang.CodeGeneration.JasminJava;

public sealed class retInstruction : IndexedInstruction
{
    public retInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public retInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}

public sealed class aloadInstruction : IndexedInstruction
{
    public aloadInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public aloadInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}

public sealed class astoreInstruction : IndexedInstruction
{
    public astoreInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public astoreInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}

public sealed class dloadInstruction : IndexedInstruction
{
    public dloadInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public dloadInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}

public sealed class dstoreInstruction : IndexedInstruction
{
    public dstoreInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public dstoreInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}

public sealed class floadInstruction : IndexedInstruction
{
    public floadInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public floadInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}

public sealed class fstoreInstruction : IndexedInstruction
{
    public fstoreInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public fstoreInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}

public sealed class iloadInstruction : IndexedInstruction
{
    public iloadInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public iloadInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}

public sealed class istoreInstruction : IndexedInstruction
{
    public istoreInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public istoreInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}

public sealed class lloadInstruction : IndexedInstruction
{
    public lloadInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public lloadInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}

public sealed class lstoreInstruction : IndexedInstruction
{
    public lstoreInstruction WithName(string name)
    {
        Name = name;
        return this;
    }

    public lstoreInstruction WithIndex(int index)
    {
        VarIndex = index;
        return this;
    }
}