using System;
using System.Globalization;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using MathLang.Extensions;


namespace MathLang
{
    public class Program
    {
        // "культуронезависимый" формат для чисел (с разделителем точкой)
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
                // в зависимости от наличия параметров командной строки разбираем
                // либо файл с именем, переданным первым параметром, либо стандартный ввод
                ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                                     : (ICharStream)new ANTLRReaderStream(Console.In);
                MathLangLexer lexer = new MathLangLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                MathLangParser parser = new MathLangParser(tokens);
                ITree program = (ITree)parser.execute().Tree;
                AstNodePrinter.Print(program);
                Tree.Nodes.Program astProgram = new Tree.Nodes.Program(null);
                astProgram.Construct(program.CastTo<CommonTree>());
                int noop = 0;
                //Console.WriteLine();
                //MathLangIntepreter.Execute(program);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            Console.ReadLine();
        }
    }
}
