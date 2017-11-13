using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using SyntaxNodeType = MathLang.MathLangParser;

namespace MathLang.Tree.Nodes
{
    public interface IExpression : INode
    {
        void Run(CommonTree tree);
    }

    public interface IStatement : INode
    {

    }

    public class Program : INode
    {
        public INode Parent { get; set; }
        public List<Class> ClassNodes { get; }

        //public Program(List<Class> classNodes)
        //{
        //    ClassNodes = classNodes;
        //}

        public Program()
        {
            ClassNodes = new List<Class>();
        }

        public void Run(CommonTree syntaxProgram)
        {
            syntaxProgram.Children
                .Cast<CommonTree>()
                .ForEach(syntaxClass =>
                {
                    Class @class = new Class();
                    ClassNodes.Add(@class);
                    @class.Parent = this;
                    @class.Run(syntaxClass);
                });
        }
    }

    public class Class : INode
    {
        public INode Parent { get; set; }

        public string Name { get; set; }
        public List<VariableDeclaration> VarDeclarationNodes { get; }
        public List<FunctionDeclaration> FunctionDeclarationNodes { get; }

        //public Class(string name, List<VariableDeclaration> varDeclarationNodes, List<FunctionDeclaration> functionDeclarationNodes)
        //{
        //    Name = name;
        //    VarDeclarationNodes = varDeclarationNodes;
        //    FunctionDeclarationNodes = functionDeclarationNodes;
        //}

        public Class()
        {
            VarDeclarationNodes = new List<VariableDeclaration>();
            FunctionDeclarationNodes = new List<FunctionDeclaration>();
        }

        public void Run(CommonTree syntaxClass)
        {
            Name = syntaxClass.Children[0].Text;
            var classblock = syntaxClass.GetChild(1) as CommonTree;
            classblock.Children
                .Cast<CommonTree>()
                .ForEach(child =>
            {
                if (child.Type == SyntaxNodeType.STATIC_DECLARATION)
                {
                    List<VariableDeclaration> variableList 
                        =  TreeHelper.RunMultiDeclaration(this, child.GetChild(0) as CommonTree);
                    VarDeclarationNodes.AddRange(variableList);
                }
                else if (child.Type == SyntaxNodeType.FUNCDECLARATION)
                {
                    FunctionDeclaration function = new FunctionDeclaration();
                    FunctionDeclarationNodes.Add(function);
                    function.Parent = this;
                    function.Run(child);
                }
            });
        }
    }

    
    public class FunctionDeclaration : INode
    {
        public INode Parent { get; set; }

        public string Name { get; }
        public ReturnType ReturnType { get; }
        public List<Parameter> ParameterNodes { get; }
        public List<IStatement> StatementNodes { get; }

        //public FunctionDeclaration(List<IStatement> statementNodes, List<Parameter> parameterNodes,
        //    ReturnType returnType, string name)
        //{
        //    StatementNodes = statementNodes;
        //    ParameterNodes = parameterNodes;
        //    ReturnType = returnType;
        //    Name = name;
        //}
        public FunctionDeclaration()
        {
            
        }

        public void Run(CommonTree child)
        {
            throw new System.NotImplementedException();
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


        public string Name { get; set; }
        public ReturnType ReturnType { get; set; }
        public IExpression Value { get; set; }

        //public VariableDeclaration(ReturnType returnType, string name, IExpression value)
        //{
        //    ReturnType = returnType;
        //    Name = name;
        //    Value = value;
        //}
        public VariableDeclaration()
        {
            
        }

        public void Run(ReturnType returnType, CommonTree syntaxVariableDeclaration)
        {
            ReturnType = returnType;
            Name = syntaxVariableDeclaration.GetChild(0).Text;
            var syntaxValueExpression = syntaxVariableDeclaration.GetChild(1) as CommonTree;
            Value = TreeHelper.RunExpression(syntaxValueExpression);
            Value.Run(syntaxValueExpression);
        }
    }
}