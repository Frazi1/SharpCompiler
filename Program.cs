using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using MathLang.CodeGeneration;
using MathLang.Extensions;
using MathLang.Tree.Semantics;


namespace MathLang
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var astProgram = new Tree.Nodes.Program();
            var paths = ExpandWildCard(args);
            try
            {
                paths.ForEach(arg =>
                {
                    ICharStream input = new ANTLRFileStream(arg);
                    MathLangLexer lexer = new MathLangLexer(input);
                    CommonTokenStream tokens = new CommonTokenStream(lexer);
                    MathLangParser parser = new MathLangParser(tokens);
                    ITree program = (ITree) parser.execute().Tree;
                    AstNodePrinter.Print(program);

                    if (ErrorService.Instance.HasErrors)
                    {
                        ErrorService.Instance.PrintErrorsToConsole();
                    }
                    astProgram.Construct(program.CastTo<CommonTree>());
                });

                //AST
                SemanticsRunner.Run(astProgram);

                //                TreeConsolePrinter tp = new TreeConsolePrinter();
                //                tp.Print(astProgram);

                JasminCodeGenerator generator = new JasminCodeGenerator();
                generator.GenerateCode(astProgram);
                generator.SaveFiles();
                //Helpers.FilePrinter.WriteTextToFile(generator.CodeListing, "output.j");
                //Console.WriteLine(generator.CodeListing);
                RunJasminBuildScript();
            }
            catch (Exception e)
            {
#if DEBUG
                Console.WriteLine("Error: {0}", e);   
#else
                Console.WriteLine("Error: {0}", e.Message);
#endif
            }
#if DEBUG
            Console.ReadKey();
#endif
        }

        private static IEnumerable<string> ExpandWildCard(IEnumerable<string> wildcards)
        {
            var result = new List<string>();
            wildcards.ForEach(s =>
            {
                if (!s.Contains("*"))
                {
                    result.Add(s);
                    return;
                }

                int folderPathLength = s.LastIndexOf("/", StringComparison.Ordinal);
                string wildCard, folderPath;
                if (folderPathLength > 0)
                {
                    folderPath = s.Substring(0, folderPathLength);
                    wildCard = s.Substring(folderPathLength + 1);
                }
                else
                {
                    folderPath = Directory.GetCurrentDirectory();
                    wildCard = s;
                }
                DirectoryInfo directory = new DirectoryInfo(folderPath);
                var fileInfos = directory.GetFiles(wildCard);
                fileInfos.ForEach(info => result.Add(info.FullName));
            });
            return result;
        }

        private static void RunJasminBuildScript()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            //            startInfo.FileName = "jasmin_build.bat";
#if DEBUG
            startInfo.FileName = "RunScripts/jasmin_build.bat";
#else
            startInfo.FileName = "jasmin_build.bat";
#endif
            //            startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            //            startInfo.Arguments = "-jar %JASMIN_PATH% *.j >jasmin_buildlog.txt 2>&1";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}