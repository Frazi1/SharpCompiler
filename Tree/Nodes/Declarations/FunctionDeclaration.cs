using System.Collections.Generic;
using Antlr.Runtime.Tree;

namespace MathLang.Tree.Nodes
{
    public class FunctionDeclaration : INode
    {
        public INode Parent { get; }

        public string Name { get; set; }
        public ReturnType ReturnType { get; set; }
        public List<Parameter> ParameterNodes { get; }
        public List<IStatement> StatementNodes { get; }

        public FunctionDeclaration(INode parent)
        {
            Parent = parent;
            ParameterNodes = new List<Parameter>();
            StatementNodes = new List<IStatement>();
        }

        public void Construct(CommonTree child)
        {
            throw new System.NotImplementedException();
        }
    }
}