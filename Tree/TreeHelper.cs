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
                case VARDECLARATION: return ExpressionType.VariableDeclaration;
                case ID: return ExpressionType.VariableReference;
                case ARRAYELEMENT: return ExpressionType.ArrayElementReference;
                default: throw new ArgumentException(nameof(type));
            }
        }

        public static IExpression GetExpression(INode parent, Scope parentScope, CommonTree syntaxExpression)
        {
            var type = syntaxExpression.Type;
            if (IsBoolExpression(type))
                return new BoolExpression(parent, parentScope);
            //if (IsAtomNode(syntaxExpression.Type))
            //{
            //    return new Atom(parent, parentScope);
            //}
            switch (syntaxExpression.Type)
            {
                case FUNC_CALL: return new FunctionCall(parent, parentScope);
                //case VARDECLARATION: return new VariableDeclaration(parent, parentScope);
                //case VARASSIGNMENT: return new VariableAssignment(parent, parentScope);
                case ID: return new VariableReference(parent, parentScope);
                case ARRAY_INITIALIZER: return new NewArray(parent, parentScope);
                case ARRAYELEMENT: return new ArrayElementReference(parent, parentScope);
                case EXTENDED_ID: return new ExtendedId(parent, parentScope);
                case CHAR: return new CharExpression(parent, parentScope);
                case NUMBER: return new IntExpression(parent, parentScope);
            }
            return new Expression(parent, parentScope);
        }

        private static bool IsBoolExpression(int type)
        {
            return type == LS
                   || type == LSEQ
                   || type == GR
                   || type == GREQ
                   || type == EQ
                   || type == NEQ
                   || type == NOT
                   || type == AND
                   || type == OR
                   || type == FALSE
                   || type == TRUE;
        }

        //public static bool IsAtomNode(int type)
        //{
        //    return new[] {TRUE, FALSE, NUMBER, CHAR /*, ID*/}
        //        .Contains(type);
        //}


        //We need a list here because we get a list of variable declarations from MULT_DECL syntax node
        //so everything will be a list of 1 element (in most cases)
        public static List<IStatement> GetStatements(INode parentNode, Scope parentScope, CommonTree syntaxStatement)
        {
            //Fucking switch does not allow usage of "if" so...
            //if (IsAtomNode(syntaxStatement.Type))
            //{
            //    return new Atom(parentNode, parentScope).AsListOf<IStatement>();
            //}

            var type = syntaxStatement.Type;
            if (IsBoolExpression(type))
                return new BoolExpression(parentNode, parentScope).AsListOf<IStatement>();

            switch (syntaxStatement.Type)
            {
                case IF: return new IfStatement(parentNode, parentScope).AsListOf<IStatement>();
                case DO: return new DoWhileStatement(parentNode).AsListOf<IStatement>();
                case WHILE: return new WhileStatement(parentNode, parentScope).AsListOf<IStatement>();
                case FOR: return new ForStatement(parentNode, parentScope).AsListOf<IStatement>();
                case VARASSIGNMENT: return new VariableAssignment(parentNode, parentScope).AsListOf<IStatement>();
                case RETURN: return new ReturnStatement(parentNode, parentScope).AsListOf<IStatement>();
                case FUNC_CALL: return new FunctionCall(parentNode, parentScope).AsListOf<IStatement>();
                case VARDECLARATION: return new VariableDeclaration(parentNode, parentScope).AsListOf<IStatement>();
                case ID: return new VariableReference(parentNode, parentScope).AsListOf<IStatement>();
                case BLOCK: return new BlockStatement(parentNode, parentScope).AsListOf<IStatement>();
                case ARRAYDECLARATION: return new ArrayDeclaration(parentNode, parentScope).AsListOf<IStatement>();
                case ARRAY_INITIALIZER: return new NewArray(parentNode, parentScope).AsListOf<IStatement>();
                case ARRAYELEMENTASSIGNMENT:
                    return new ArrayElementAssignment(parentNode, parentScope).AsListOf<IStatement>();
                case ARRAYELEMENT: return new ArrayElementReference(parentNode, parentScope).AsListOf<IStatement>();
                case EXTENDED_ID: return new ExtendedId(parentNode, parentScope).AsListOf<IStatement>();
                case NUMBER: return new IntExpression(parentNode, parentScope).AsListOf<IStatement>();
                case CHAR: return new CharExpression(parentNode, parentScope).AsListOf<IStatement>();
                default: throw new ArgumentOutOfRangeException(nameof(syntaxStatement.Type));
            }
        }
    }
}