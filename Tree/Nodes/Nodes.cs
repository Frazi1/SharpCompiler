using System.Collections.Generic;

namespace MathLang.Tree.Nodes
{
    public interface IExpression : INode
    {
    }

    public interface IStatement : INode
    {

    }

    public class Program : INode
    {
        public INode Parent { get; set; }
        public List<ClassNode> ClassNodes { get; }

        public Program(List<ClassNode> classNodes)
        {
            ClassNodes = classNodes;
        }

    }

    public class ClassNode : INode
    {
        public INode Parent { get; set; }

        public string Name { get; }
        public List<VariableDeclaration> VarDeclarationNodes { get; }
        public List<FunctionDeclaration> FunctionDeclarationNodes { get; }

        public ClassNode(string name, List<VariableDeclaration> varDeclarationNodes, List<FunctionDeclaration> functionDeclarationNodes)
        {
            Name = name;
            VarDeclarationNodes = varDeclarationNodes;
            FunctionDeclarationNodes = functionDeclarationNodes;
        }
    }

    public class FunctionDeclaration : INode
    {
        public INode Parent { get; set; }

        public string Name { get; }
        public ReturnType ReturnType { get; }
        public List<Parameter> ParameterNodes { get; }
        public List<IStatement> StatementNodes { get; }

        public FunctionDeclaration(List<IStatement> statementNodes, List<Parameter> parameterNodes,
            ReturnType returnType, string name)
        {
            StatementNodes = statementNodes;
            ParameterNodes = parameterNodes;
            ReturnType = returnType;
            Name = name;
        }
    }

    public class Parameter : INode
    {
        public INode Parent { get; set; }

        //TODO: position
        public ReturnType ReturnType { get; }

        public Parameter(ReturnType returnType)
        {
            ReturnType = returnType;
        }
    }

    public class VariableDeclaration : INode
    {
        public INode Parent { get; set; }

        public string Name { get; }
        public ReturnType ReturnType { get; }
        public IExpression Value { get; }

        public VariableDeclaration(ReturnType returnType, string name, IExpression value)
        {
            ReturnType = returnType;
            Name = name;
            Value = value;
        }
    }
}