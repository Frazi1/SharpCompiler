using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes;
using static MathLang.MathLangParser;
using SyntaxNodeTypes = MathLang.MathLangParser;

namespace MathLang.Tree
{
    public static class TreeHelper
    {
        public static List<VariableDeclaration> RunMultiDeclaration(INode parentNode, CommonTree syntaxMultiDeclaration)
        {
            ReturnType returnType = GetReturnType(syntaxMultiDeclaration.GetChild(0).Text);
            List<VariableDeclaration> variableList = new List<VariableDeclaration>();

            syntaxMultiDeclaration
                 .GetChild(1).CastTo<CommonTree>()
                 .Children.Cast<CommonTree>()
                 .ForEach(varDecl =>
                 {
                     VariableDeclaration variable = new VariableDeclaration(parentNode, returnType);
                     variable.Construct(varDecl);
                     variableList.Add(variable);
                 });
            return variableList;
        }

        public static ReturnType GetReturnType(string type)
        {
            switch (type)
            {
                case "int": return ReturnType.Int;
                case "bool": return ReturnType.Bool;
                case "char": return ReturnType.Char;
                case "void": return ReturnType.Void;
                default: throw new ArgumentException(nameof(type));
            }
        }

        public static ExpressionType GetExpressionType(int type)
        {
            switch (type)
            {
                case ADD: return ExpressionType.Add;
                case SUB: return ExpressionType.Sub;
                case DIV: return ExpressionType.Div;
                case MUL: return ExpressionType.Mul;
                case GR: return ExpressionType.Greater;
                case LS: return ExpressionType.Less;
                case EQ: return ExpressionType.Equal;
                case NEQ: return ExpressionType.NotEqual;
                case GREQ: return ExpressionType.EqualOrGreater;
                case LSEQ: return ExpressionType.EqualOrLess;
                case NOT: return ExpressionType.Not;
                case OR: return ExpressionType.Or;
                case AND: return ExpressionType.And;
                case FUNC_CALL: return ExpressionType.FunctionCall;
                default: throw new ArgumentException(nameof(type));
            }
        }

        public static IExpression GetExpression(INode parent, CommonTree syntaxExpression)
        {
            if (syntaxExpression.Type == FUNC_CALL)
            {
                return new FunctionCall(parent);
            }
            else if (IsAtomNode(syntaxExpression.Type))
            {
                return new AtomExpression(parent);
            }
            else
            {
                return new Expression(parent);
            }
        }

        public static bool IsAtomNode(int type)
        {
            return new[] { TRUE, FALSE, NUMBER, CHAR, ID }
                .Contains(type);
        }

        
        //We need a list here because we get a list of variable declarations from MULT_DECL syntax node
        //so everything will be a list of 1 element (in most cases)
        public static List<IStatement> GetStatements(INode functionParent, CommonTree syntaxStatement)
        {

            switch (syntaxStatement.Type)
            {
                case IF: return new IfStatement(functionParent).AsListOf<IStatement>();
                case DO: return new DoWhileStatement(functionParent).AsListOf<IStatement>();
                case WHILE: return new WhileStatement(functionParent).AsListOf<IStatement>();
                case FOR: return new ForStatement(functionParent).AsListOf<IStatement>();
                case VARASSIGNMENT: return new VariableAssignmentStatement(functionParent).AsListOf<IStatement>();
                //Not to implement
                //case ARRAYELEMENTASSIGNMENT: return new ArrayElementAssignmentStatement(functionParent).AsListOf<IStatement>();
                //Think something up here because we dont want MULT_DECL to be in the new tree
                case MULT_DECL: return RunMultiDeclaration(functionParent, syntaxStatement).AsListOf<IStatement>();

                //And here
                //case MULT_ARRAY_DECL:

                case RETURN: return new ReturnStatement(functionParent).AsListOf<IStatement>();
                case FUNC_CALL: return new FunctionCall(functionParent).AsListOf<IStatement>();

                //Cannot be here
                //case VARDECLARATION: return new VariableDeclaration();
                default: throw new ArgumentOutOfRangeException(nameof(syntaxStatement.Type));
            }
        }
    }

    public class ReturnStatement : IStatement
    {
        public INode Parent { get; }

        public ReturnStatement(INode parent)
        {
            Parent = parent;
        }
        
        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }

    public class ArrayElementAssignmentStatement : IStatement
    {
        public INode Parent { get; }

        public ArrayElementAssignmentStatement(INode parent)
        {
            Parent = parent;
        }
        
        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }

    public class VariableAssignmentStatement : IStatement
    {
        public INode Parent { get; }

        public VariableAssignmentStatement(INode parent)
        {
            Parent = parent;
        }
        
        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }

    public class ForStatement : IStatement
    {
        public INode Parent { get; }

        public ForStatement(INode parent)
        {
            Parent = parent;
        }
        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }

    public class WhileStatement : IStatement
    {
        public INode Parent { get; }

        public WhileStatement(INode parent)
        {
            Parent = parent;
        }

        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }

    public class IfStatement : IStatement
    {
        public INode Parent { get; }

        public IfStatement(INode parent)
        {
            Parent = parent;
        }

        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }
    }
    public class DoWhileStatement: IStatement
    {
        public INode Parent { get; }

        public DoWhileStatement(INode parent)
        {
            Parent = parent;
        }

        public void Construct(CommonTree tree)
        {
            throw new NotImplementedException();
        }

    }
}