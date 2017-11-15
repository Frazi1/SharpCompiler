namespace MathLang.Tree.Nodes
{
    public enum ExpressionType
    {
        Unset = 0,
        Add,
        Sub,
        Mul,
        Div,
        Equal,
        Greater,
        EqualOrGreater,
        Less,
        EqualOrLess,
        NotEqual,
        Not,
        Or,
        And,
        FunctionCall
    }
}