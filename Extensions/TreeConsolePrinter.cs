using System;
using System.Collections.Generic;
using System.Linq;
using MathLang.Tree.Nodes.Declarations;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Nodes.Expressions;
using MathLang.Tree.Nodes.Interfaces;
using MathLang.Tree.Nodes.Statements;

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

            List<ClassDeclaration> printableClassNodes = treeProgram.ClassNodes.Where(c => c.IsPrintable).ToList();            
            
            for (int i = 0; i < printableClassNodes.Count; i++)
            {
                string ind = ((i + 1) == printableClassNodes.Count) ? 
                    indentEndBar : indentBranchBar;
                string nextInd = (i + 1 == printableClassNodes.Count) ?
                    indent : indentBar;

                var staticModifier = printableClassNodes[i].IsStatic ? "static" : "";
                Console.WriteLine($"{indent}" +
                                  $"{ind}{staticModifier} class {printableClassNodes[i].Name}");

                for (int k = 0; k < printableClassNodes[i].VarDeclarationNodes.Count; k++)
                {
                    bool last = (k + 1 == printableClassNodes[i].VarDeclarationNodes.Count) &&
                                (printableClassNodes[i].FunctionDeclarationNodes.Count == 0);

                    PrintStatement(indent+ nextInd, 
                        printableClassNodes[i].VarDeclarationNodes[k],
                        last);
                }

                for (int b = 0; b < printableClassNodes[i].FunctionDeclarationNodes.Count; b++)
                {
                    PrintFuncDeclaration(indent+ nextInd, 
                        printableClassNodes[i].FunctionDeclarationNodes[b],
                        b+1 == printableClassNodes[i].FunctionDeclarationNodes.Count);
                }
            }
        }

        //protected void PrintVarDeclaration(string ind, Declaration declaration, bool isFinal)
        //{

        //    Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
        //                      $"{declaration.Name} " +
        //                      $"({declaration.ReturnType})");
        //    if (declaration.Value != null)
        //    {
        //        PrintExpression(ind + (isFinal? indent : indentBar) , declaration.Value, true);
        //    }
        //}

        protected void PrintFuncDeclaration(string ind, FunctionDeclaration funcDecl, bool isFinal)
        {
            Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}func {funcDecl.Name} returns" +
                              $" {funcDecl.ReturnType}");

            //params
            if (funcDecl.ParameterNodes.Count > 0)
            {
                Console.WriteLine($"{ind}{(isFinal ? indent : indentBar)}" +
                                  $"{(funcDecl.StatementBlock?.Statements.Count==0? indentEndBar:indentBranchBar)}paremeters");

                for (int k = 0; k < funcDecl.ParameterNodes.Count; k++)
                {
                    Console.WriteLine($"{ind}{(isFinal ? indent : indentBar)}" +
                                      $"{(funcDecl.StatementBlock?.Statements.Count == 0 ? indent : indentBar)}" +
                                      $"{(k+1 == funcDecl.ParameterNodes.Count? indentEndBar: indentBranchBar)}" +
                                      $"{funcDecl.ParameterNodes[k].Name} ({funcDecl.ParameterNodes[k].ReturnType})"+
                                      $"{(funcDecl.ParameterNodes[k].Index == null ? "" : $" with funcParam {funcDecl.ParameterNodes[k].Index}")}");
                }
            }

            //block
            if (funcDecl.StatementBlock?.Statements.Count > 0)
            {
                PrintStatement($"{ind}{(isFinal ? indent : indentBar)}", funcDecl.StatementBlock, true);

                //Console.WriteLine($"{ind}{(isFinal ? indent : indentBar)}" +
                //                  $"{indentBranchBar}block");

                //for (int k = 0; k < funcDecl.StatemenBlock.Statements.Count; k++)
                //{
                //    PrintStatement($"{ind}{(isFinal ? indent : indentBar)}{indent}" ,
                //                      //$"{(k + 1 == funcDecl.StatemenBlock.Statements.Count ? indentEndBar : indentBranchBar)}" +
                //                      funcDecl.StatemenBlock.Statements[k], k + 1 == funcDecl.StatemenBlock.Statements.Count );
                //}
            }
        }

        protected void PrintStatement(string ind, IStatement statement, bool isFinal)
        {
            if (statement is BlockStatement block)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"{(block.Statements.Count>0? "block":"empty block")}");

                for (int k = 0; k < block.Statements.Count; k++)
                {
                    PrintStatement($"{ind}{(isFinal ? indent : indentBar)}",
                        //$"{(k + 1 == funcDecl.StatemenBlock.Statements.Count ? indentEndBar : indentBranchBar)}" +
                        block.Statements[k], k + 1 == block.Statements.Count);
                }
                return;
            }

            if (statement is ReturnStatement ret)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}return");

                if (ret.ReturnExpression != null)
                {
                    PrintExpression($"{ind}{(isFinal ? indent : indentBar)}", ret.ReturnExpression, true);
                }
                return;
            }

            if (statement is WhileStatement whileStat)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}while");

                PrintExpression($"{ind}{(isFinal ? indent : indentBar)}", whileStat.ConditionExpression, 
                    whileStat.BlockOrSingleStatement==null);

                if (whileStat.BlockOrSingleStatement != null)
                {
                    PrintStatement($"{ind}{(isFinal ? indent : indentBar)}", whileStat.BlockOrSingleStatement,true);
                }

                return;
            }

            if (statement is ForStatement forStat)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}for");
                //initialization condition iteration
                Console.WriteLine($"{ind}{(isFinal ? indent : indentBar)}{indentBranchBar}initialization");
                PrintStatement($"{ind}{(isFinal ? indent : indentBar)}{indentBar}",forStat.InitializationStatement, true);

                Console.WriteLine($"{ind}{(isFinal ? indent : indentBar)}{indentBranchBar}condition");
                PrintExpression($"{ind}{(isFinal ? indent : indentBar)}{indentBar}", forStat.ConditionExpression, true);

                Console.WriteLine($"{ind}{(isFinal ? indent : indentBar)}{indentBranchBar}iteration");
                PrintStatement($"{ind}{(isFinal ? indent : indentBar)}{indentBar}", forStat.IterationStatement, true);

                PrintStatement($"{ind}{(isFinal ? indent : indentBar)}", forStat.BlockOrSingleStatement, true);
            }

            if (statement is IfStatement ifStat)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}if");

                PrintExpression($"{ind}{(isFinal ? indent : indentBar)}", ifStat.ConditionExpression,
                    ifStat.TrueCaseBlockStatement == null);

                if (ifStat.TrueCaseBlockStatement != null)
                {
                    PrintStatement($"{ind}{(isFinal ? indent : indentBar)}", 
                        ifStat.TrueCaseBlockStatement, ifStat.FasleCaseBlockStatement==null);
                }
                if (ifStat.FasleCaseBlockStatement!= null)
                {
                    PrintStatement($"{ind}{(isFinal ? indent : indentBar)}",
                        ifStat.FasleCaseBlockStatement, true);
                }
                return;
            }
            if (statement is Declaration declaration)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"DECLARE {declaration.Name} " +
                                  $"of type {declaration.ReturnType}" +
                                  $"{(declaration.Index == null? "": $" with funcIndex {declaration.Index}")}");
                if (declaration.Value != null)
                {
                    PrintExpression(ind + (isFinal ? indent : indentBar), declaration.Value, true);
                }
                return;
            }
            if (statement is VariableAssignment varAss)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}ASSIGN {varAss.VariableName} = ");

                PrintExpression($"{ind}{(isFinal ? indent : indentBar)}", varAss.AssignmentValue,true);

                return;
            }
            if (statement is ArrayElementAssignment arrAss)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}ASSIGN");

                PrintExpression($"{ind}{(isFinal ? indent : indentBar)}",
                            arrAss.ArrayElementReference, false);
                PrintExpression($"{ind}{(isFinal ? indent : indentBar)}",
                    arrAss.AssignmentExpression, true);
                return;
            }
            if (statement is FunctionCall fCall)
            {
                PrintExpression($"{ind}", fCall, isFinal);
            }
        }

        protected void PrintExpression(string ind, IExpression expression, bool isFinal)
        {
            //Console.WriteLine($"{ind}");

            if (expression is Expression ex)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"{ParseExpressionType(ex.ExpressionType)}" +
                                  $"{(ex.CastToType == null ? "" : $" [cast to {ex.CastToType}]")}");

                                
                PrintExpression($"{ind}{(isFinal? indent : indentBar)}", ex.Left, ex.Right == null);

                if (ex.Right != null)
                {
                    PrintExpression($"{ind}{(isFinal ? indent : indentBar)}", ex.Right, true);
                }
                return;
            }

            if (expression is Atom atom)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"{atom.Value} ({atom.ReturnType.ToString()})" +
                                  $"{(atom.CastToType == null ? "" : $" [cast to {atom.CastToType}]")}");
                return;
            }

            if (expression is ExtendedId exId)
            {
                string s = exId.Declaration is FunctionDeclarationParameter ? "funcParam" : "funcIndex";
                
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"{exId.Name} ({exId.ReturnType}) " +
                                  $"{((exId.Declaration?.Index == null ) ? "": $" with {s} {exId.Declaration.Index}")}"+
                                  $"{(exId.CastToType == null ? "" : $" [cast to {exId.CastToType}]")}");
                return;
            }

            if (expression is VariableReference varRef)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"{varRef.Name.ToString()}"+
                                  $"{(varRef.CastToType == null ? "" : $" [cast to {varRef.CastToType}]")}");
            }

            if (expression is NewArray newArr)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"new {newArr.ReturnType}");

                if (newArr.ArraySize != null)
                {
                    Console.WriteLine($"{ind}{(isFinal ? indent : indentBranchBar)}" +
                                      $"{(newArr.InitializationParameters.Count == 0 ? indentEndBar : indentBranchBar)}" +
                                      $"size");

                    PrintExpression($"{ind}{(isFinal ? indent : indentBar)}" +
                                   $"{(newArr.InitializationParameters.Count == 0 ? indent : indentBar)}",
                        newArr.ArraySize, true);
                }

                if (newArr.InitializationParameters.Count != 0)
                {
                    Console.WriteLine($"{ind}{(isFinal ? indent : indentBranchBar)}" +
                                      $"{indentEndBar}" +
                                      $"init params");

                    for (int p =0; p < newArr.InitializationParameters.Count; p++)
                    {
                        PrintExpression($"{ind}{(isFinal ? indent : indentBar)}" +
                                       $"{indent}",
                            newArr.InitializationParameters[p], p+1 == newArr.InitializationParameters.Count);
                    }
                }
                return;
            }

            if (expression is FunctionCall fc)
            {
                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"CALL {fc.ExtendedId} that returns {fc.ReturnType}" +
                                  $"{(fc.CastToType == null ? "" : $" [cast to {fc.CastToType}]")}");

                if (fc.FunctionCallParameters.Count > 0)
                {
                    Console.WriteLine($"{ind}{(isFinal ? indent : indentBar)}" +
                                      $"{indentEndBar}" +
                                      $"params");

                    for (int p = 0; p < fc.FunctionCallParameters.Count; p++)
                    {
                        PrintExpression($"{ind}{(isFinal ? indent : indentBar)}" +
                                       $"{indent}",
                            fc.FunctionCallParameters[p], p + 1 == fc.FunctionCallParameters.Count);
                    }
                }
            }

            if (expression is ArrayElementReference arrEl)
            {
                string s = arrEl.Name.Declaration is FunctionDeclarationParameter ? "funcParam" : "funcIndex";

                Console.WriteLine($"{ind}{(isFinal ? indentEndBar : indentBranchBar)}" +
                                  $"element ({arrEl.ReturnType}) " +
                                  $"{(arrEl.CastToType == null ? "" : $" [cast to {arrEl.CastToType}]")}" +
                                  $" of array {arrEl.Name} " +
                                  $"{(arrEl.Name.Declaration.Index == null? "": $"with {s} {arrEl.Name.Declaration.Index}")}" +
                                  $" with array index :");

                PrintExpression($"{ind}{(isFinal ? indent : indentBar)}", arrEl.ArrayIndex, true);
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
