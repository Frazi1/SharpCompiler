using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using JasminSharp.Helpers;
using MathLang.CodeGeneration.JasminJava;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Semantics;


namespace MathLang
{
    public class Program
    {
        // "�������������������" ������ ��� ����� (� ������������ ������)
        public static readonly NumberFormatInfo NFI = new NumberFormatInfo();
        
        public static void Main(string[] args)
        {
            try
            {
                // � ����������� �� ������� ���������� ��������� ������ ���������
                // ���� ���� � ������, ���������� ������ ����������, ���� ����������� ����
                ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                                     : (ICharStream)new ANTLRReaderStream(Console.In);
                MathLangLexer lexer = new MathLangLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                MathLangParser parser = new MathLangParser(tokens);
                ITree program = (ITree)parser.execute().Tree;

                //AstNodePrinter.Print(program);

                if (ErrorService.Instance.HasErrors)
                {
                    ErrorService.Instance.PrintErrorsToConsole();
                    return;
                }
                //AST
                Tree.Nodes.Program astProgram = new Tree.Nodes.Program();
                astProgram.Construct(program.CastTo<CommonTree>());
                SemanticsRunner.Run(astProgram);

                TreeConsolePrinter tp = new TreeConsolePrinter();
                tp.Print(astProgram);



                JasminCodeGenerator generator = new JasminCodeGenerator();
                generator.GenerateCode(astProgram);
                Helpers.FilePrinter.WriteTextToFile(generator.CodeListing, "output.j");
                Console.WriteLine(generator.CodeListing);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            Console.ReadLine();
        }
    }
}
