using System;
using System.Globalization;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using MathLang.CodeGeneration;
using MathLang.Extensions;
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

                AstNodePrinter.Print(program);

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
                generator.SaveFiles();
                //Helpers.FilePrinter.WriteTextToFile(generator.CodeListing, "output.j");
                //Console.WriteLine(generator.CodeListing);
                //RunJasminBuildScript();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            Console.ReadLine();
        }
        static int Fibbonacchi(int n)
        {
            return n > 1 ? Fibbonacchi(n - 1) + Fibbonacchi(n - 2) : n;
        }

        private static void RunJasminBuildScript()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "jasmin_build.bat";
            //startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
