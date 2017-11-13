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
        public static List<VariableDeclaration> RunMultiDeclaration(Class parentClass, CommonTree syntaxMultiDeclaration)
        {
            ReturnType returnType = GetReturnType(syntaxMultiDeclaration.GetChild(0).Text);
            List<VariableDeclaration> variableList = new List<VariableDeclaration>();

            syntaxMultiDeclaration
                 .GetChild(1)
                 .Cast<ITree, CommonTree>()
                 .Children
                 //.Skip(1)
                 .Cast<CommonTree>()
                 .ForEach(varDecl =>
                 {
                     VariableDeclaration variable = new VariableDeclaration();
                     variable.Parent = parentClass;
                     variable.Run(returnType, varDecl);
                     //parentClass.VarDeclarationNodes.Add(variable);
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
                default: throw new ArgumentException(nameof(type));
            }
        }

        public static IExpression RunExpression(CommonTree syntaxExpression)
        {
            if (syntaxExpression.Type == FUNC_CALL)
            {
                FunctionCallExpression functionCallExpression = new FunctionCallExpression();
                //functionCallExpression.Run(syntaxExpression);
                return functionCallExpression;
            }
           
            else if (IsAtomNode(syntaxExpression.Type))
            {
                AtomExpression atomExpression = new AtomExpression();
                return atomExpression;
            }
            else
            {
                Expression expression = new Expression();
                //expression.Run(syntaxExpression);
                return expression;
            }
        }

        public static bool IsAtomNode(int type)
        {
            return new[] {TRUE, FALSE, NUMBER, CHAR, ID}
                .Contains(type);
        }
    }
}