using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;

namespace MathLang.Extensions
{
    public class TreeConsolePrinter
    {
        //│
        //└
        //├
        protected readonly string indent = "  ";

        protected readonly string indentBar = "│ ";

        protected readonly string indentBranchBar = "├ ";

        protected readonly string indentEndBar = "└ ";

        public void Print(Tree.Nodes.Program treeProgram)
        {
            Console.WriteLine("program");
            
            for (int i = 0; i < treeProgram.ClassNodes.Count; i++)
            {
                string ind = ((i + 1) == treeProgram.ClassNodes.Count) ? 
                    indentEndBar : indentBranchBar;
                string nextInd = (i + 1 == treeProgram.ClassNodes.Count) ?
                    indent : indentBar;

                Console.WriteLine($"{indent}" +
                                  $"{ind}class {treeProgram.ClassNodes[i].Name}");

                for (int k = 0; k < treeProgram.ClassNodes[i].VarDeclarationNodes.Count; k++)
                {
                    bool last = (k + 1 == treeProgram.ClassNodes[i].VarDeclarationNodes.Count) &&
                                (treeProgram.ClassNodes[i].FunctionDeclarationNodes.Count == 0);

                    PrintVarDeclaration(indent+ nextInd, 
                        treeProgram.ClassNodes[i].VarDeclarationNodes[k],
                        last);
                }

                for (int b = 0; b < treeProgram.ClassNodes[i].FunctionDeclarationNodes.Count; b++)
                {
                    PrintFuncDeclaration(indent+ nextInd, 
                        treeProgram.ClassNodes[i].FunctionDeclarationNodes[b],
                        b+1 == treeProgram.ClassNodes[i].FunctionDeclarationNodes.Count);
                }
            }
        }

        protected void PrintVarDeclaration(string ind, Declaration declaration, bool isFinal)
        {

            Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                              $"{declaration.Name} " +
                              $"({declaration.ReturnType})");
            if (declaration.Value != null)
            {
                PrintExpresion(ind + (isFinal? indent : indentBar) , declaration.Value, true);
            }
        }

        protected void PrintFuncDeclaration(string ind, FunctionDeclaration functionDeclaration, bool isFinal)
        {
            Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}{functionDeclaration.Name} returns" +
                              $" {functionDeclaration.ReturnType}");
            if (functionDeclaration.ParameterNodes.Count > 0)
            {
                Console.WriteLine($"{ind}{(isFinal ? indent : indentBar)}{indentBranchBar} paremeters");


            }
        }

        protected void PrintExpresion(string ind, IExpression expression, bool isFinal)
        {
            //Console.WriteLine($"{ind}");

            if (expression is Expression ex)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"{ParseExpressionType(ex.ExpressionType)} {ParseExpressionType(ex.ExpressionType)}");

                                
                PrintExpresion($"{ind}{(isFinal? indent : indentBar)}", ex.Left, ex.Right == null);

                if (ex.Right != null)
                {
                    PrintExpresion($"{ind}{(isFinal ? indent : indentBar)}", ex.Right, true);
                }
                return;
            }

            if (expression is Atom atom)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"{atom.Value} ({atom.ReturnType.ToString()})");
                return;
            }

            if (expression is ExtendedId exId)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"{exId.GetFullPath}");
                return;
            }

            if (expression is NewArray)
            {

            }

            if (expression is VariableReference varRef)
            {
                varRef.
            }
        }

        protected string ParseExpressionType(ExpressionType ex)
        {
            
            switch (ex)
            {
                case ExpressionType.Unset:
                    return "";
                case ExpressionType.Add:
                    return "+";
                case ExpressionType.Sub:
                    return "-";
                case ExpressionType.Mul:
                    return "*";
                case ExpressionType.Div:
                    return "/";
                case ExpressionType.Equal:
                    return "==";
                case ExpressionType.Greater:
                    return ">";
                case ExpressionType.EqualOrGreater:
                    return ">=";
                case ExpressionType.Less:
                    return "<";
                case ExpressionType.EqualOrLess:
                    return "<=";
                case ExpressionType.NotEqual:
                    return "!=";
                case ExpressionType.Not:
                    return "!";
                case ExpressionType.Or:
                    return "||";
                case ExpressionType.And:
                    return "&&";
                case ExpressionType.FunctionCall:
                    return "";
                case ExpressionType.VariableDeclaration:
                    return "";
                case ExpressionType.VariableReference:
                    return "";
                case ExpressionType.ArrayElementReference:
                    return "";
            }

            return "";
        }
    }
}
