using MathLang.CodeGeneration.JasminJava;

public sealed class retInstruction : IJasminInstruction
{
    public string Name { get; } = "ret";
    public int VarIndex { get; }

    public retInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}

public sealed class aloadInstruction : IJasminInstruction
{
    public string Name { get; } = "aload";
    public int VarIndex { get; }

    public aloadInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}

public sealed class astoreInstruction : IJasminInstruction
{
    public string Name { get; } = "astore";
    public int VarIndex { get; }

    public astoreInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}

public sealed class dloadInstruction : IJasminInstruction
{
    public string Name { get; } = "dload";
    public int VarIndex { get; }

    public dloadInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}

public sealed class dstoreInstruction : IJasminInstruction
{
    public string Name { get; } = "dstore";
    public int VarIndex { get; }

    public dstoreInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}

public sealed class floadInstruction : IJasminInstruction
{
    public string Name { get; } = "fload";
    public int VarIndex { get; }

    public floadInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}

public sealed class fstoreInstruction : IJasminInstruction
{
    public string Name { get; } = "fstore";
    public int VarIndex { get; }

    public fstoreInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}

public sealed class iloadInstruction : IJasminInstruction
{
    public string Name { get; } = "iload";
    public int VarIndex { get; }

    public iloadInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}

public sealed class istoreInstruction : IJasminInstruction
{
    public string Name { get; } = "istore";
    public int VarIndex { get; }

    public istoreInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}

public sealed class lloadInstruction : IJasminInstruction
{
    public string Name { get; } = "lload";
    public int VarIndex { get; }

    public lloadInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}

public sealed class lstoreInstruction : IJasminInstruction
{
    public string Name { get; } = "lstore";
    public int VarIndex { get; }

    public lstoreInstruction(int varIndex)
    {
        VarIndex = varIndex;
    }
}