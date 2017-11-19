using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathLang.Tree.Nodes.Declarations;
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
                string ind = (i + 1 == treeProgram.ClassNodes.Count) ? 
                    indentEndBar : indentBranchBar;
                string nextInd = (i + 1 == treeProgram.ClassNodes.Count) ?
                    indent : indentBar;

                Console.WriteLine($"{indent} " +
                                  $"{ind} class {treeProgram.ClassNodes[i].Name}");

                for (int k = 0; k < treeProgram.ClassNodes[i].VarDeclarationNodes.Count; k++)
                {
                    PrintVarDeclaration(indent+ nextInd, 
                        treeProgram.ClassNodes[i].VarDeclarationNodes[k],
                        k+1 == treeProgram.ClassNodes[i].VarDeclarationNodes.Count);
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

            Console.WriteLine($"{ind}{indentBranchBar}" +
                              $" {declaration.Name} " +
                              $"({declaration.ReturnType})");
            if (declaration.Value != null)
            {
                Print(ind + (isFinal? indent : indentBar) , declaration.Value);
            }
        }

        protected void PrintFuncDeclaration(string ind, FunctionDeclaration functionDeclaration, bool isFinal)
        {
            Console.WriteLine($"{ind}{indentBranchBar} {functionDeclaration.Name} returns" +
                              $" {functionDeclaration.ReturnType}");
            if (functionDeclaration.ParameterNodes.Count > 0)
            {
                Console.WriteLine($"{ind}{(isFinal ? indent : indentBar)}{indentBranchBar} paremeters");


            }
        }

        protected void PrintExpresion(string ind, IExpression expression, bool isFinal)
        {

        }
    }
}
