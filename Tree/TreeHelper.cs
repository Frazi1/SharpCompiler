using System;
using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;
using MathLang.Tree.Scopes;
using static MathLang.MathLangParser;

namespace MathLang.Tree
{
    public static class TreeHelper
    {
        public static List<VariableDeclaration> RunMultiDeclaration(INode parentNode, Scope parentScope, CommonTree syntaxMultiDeclaration)
        {
            ReturnType returnType = GetReturnType(syntaxMultiDeclaration.GetChild(0).Text);
            List<VariableDeclaration> variableList = new List<VariableDeclaration>();

            syntaxMultiDeclaration
                 .GetChild(1).CastTo<CommonTree>()
                 .Children.Cast<CommonTree>()
                 .ForEach(varDecl =>
                 {
                     VariableDeclaration variable = new VariableDeclaration(parentNode, parentScope, returnType);
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

        public static IExpression GetExpression(INode parent, Scope parentScope, CommonTree syntaxExpression)
        {
            if (syntaxExpression.Type == FUNC_CALL)
            {
                return new FunctionCall(parent, parentScope);
            }
            else if (IsAtomNode(syntaxExpression.Type))
            {
                return new Atom(parent, parentScope);
            }
            else
            {
                return new Expression(parent, parentScope);
            }
        }

        public static bool IsAtomNode(int type)
        {
            return new[] { TRUE, FALSE, NUMBER, CHAR, ID }
                .Contains(type);
        }

        
        //We need a list here because we get a list of variable declarations from MULT_DECL syntax node
        //so everything will be a list of 1 element (in most cases)
        public static List<IStatement> GetStatements(INode parentNode, Scope parentScope, CommonTree syntaxStatement)
        {
            //Fucking switch does not allow usage of "if" so...
            if (IsAtomNode(syntaxStatement.Type))
            {
                return new Atom(parentNode, parentScope).AsListOf<IStatement>();
            }
            
            switch (syntaxStatement.Type)
            {
                case IF: return new IfStatement(parentNode, parentScope).AsListOf<IStatement>();
                case DO: return new DoWhileStatement(parentNode).AsListOf<IStatement>();
                case WHILE: return new WhileStatement(parentNode).AsListOf<IStatement>();
                case FOR: return new ForStatement(parentNode).AsListOf<IStatement>();
                case VARASSIGNMENT: return new VariableAssignmentStatement(parentNode, parentScope).AsListOf<IStatement>();
                
                //Not to implement
                //case ARRAYELEMENTASSIGNMENT: return new ArrayElementAssignmentStatement(functionParent).AsListOf<IStatement>();
                
                case MULT_DECL: return RunMultiDeclaration(parentNode, parentScope ,syntaxStatement).AsListOf<IStatement>();

                //And here
                //case MULT_ARRAY_DECL:

                case RETURN: return new ReturnStatement(parentNode).AsListOf<IStatement>();
                case FUNC_CALL: return new FunctionCall(parentNode, parentScope).AsListOf<IStatement>();

                //Cannot be here
                //case VARDECLARATION: return new VariableDeclaration();

                case BLOCK: return new BlockStatement(parentNode, parentScope).AsListOf<IStatement>();
                default: throw new ArgumentOutOfRangeException(nameof(syntaxStatement.Type));
            }
        }
    }
}