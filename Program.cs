using System;
using System.Globalization;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using MathLang.Extensions;
using MathLang.Tree.Nodes.Enums;
using MathLang.Tree.Semantics;


namespace MathLang
{
    public class Program
    {
        // "�������������������" ������ ��� ����� (� ������������ ������)
        public static readonly NumberFormatInfo NFI = new NumberFormatInfo();


        public static class ValeraOuter
        {

            public static class valera
            {
                public static int valera_child =4;
            }
        }

        public static int Test(int a) => a;
        
        public static void Main(string[] args)
        {


            ValeraOuter.valera.valera_child = 5;
            //Console.Write(new int());
            //int u = Console.ReadLine();
            //garrrr
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

                ReturnType random = ReturnType.Unset;
                Console.WriteLine(random == null);

                AstNodePrinter.Print(program);
                
                //AST
                Tree.Nodes.Program astProgram = new Tree.Nodes.Program();
                astProgram.Construct(program.CastTo<CommonTree>());
                SemanticsRunner.Run(astProgram);
                int noop = 0;


                //Console.WriteLine();
                //MathLangIntepreter.Execute(program);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            Console.ReadLine();
        }
    }
}
