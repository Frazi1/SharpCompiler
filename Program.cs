using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using MathLang.CodeGeneration;
using MathLang.Extensions;
using MathLang.Helpers;
using MathLang.Tree.Semantics;


namespace MathLang
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                ProcessArguments(args, out var files, out var parameters);
                var paths = ExpandWildCard(files);
                var compilerSettings = CompilerSettings.ParseCompilerSettings(paths, parameters);
                if (!compilerSettings.NJCLibFound)
                    Console.WriteLine($"NJCLib was not found");
                if (compilerSettings.CodeGenerationTarget == CodeGenerationTarget.None)
                    throw new Exception("Specify code generation target with argument --target=java or --target=net");
                RunCompiler(compilerSettings);
                CopyNativeLibs(compilerSettings);
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

        private static void CopyNativeLibs(CompilerSettings compilerSettings)
        {
            if (compilerSettings.CodeGenerationTarget == CodeGenerationTarget.Dotnet)
                IOHelper.CopyDirItems(CompilerSettings.DotNetNativesPath, CompilerSettings.CurrentDirectory);
            else if (compilerSettings.CodeGenerationTarget == CodeGenerationTarget.Java)
                IOHelper.CopyDirItems(CompilerSettings.JavaNativesPath, CompilerSettings.CurrentDirectory);
        }

        private static void RunCompiler(CompilerSettings compilerSettings)
        {
            var astProgram = new Tree.Nodes.Program();
            compilerSettings.FilesPaths.ForEach(path =>
            {
                ITree tree = RunSyntaxAnalysys(path);
                if (compilerSettings.PrintSyntaxTree)
                    AstNodePrinter.Print(tree);

                if (ErrorService.Instance.HasErrors)
                    ErrorService.Instance.PrintErrorsToConsole();
                else
                    astProgram.Construct(tree.CastTo<CommonTree>());
            });
            if (compilerSettings.NJCLibFound)
                astProgram.Construct(
                    RunSyntaxAnalysys(compilerSettings.NJCLibPath)
                        .CastTo<CommonTree>());

            //AST
            if (ErrorService.Instance.HasErrors) return;

            SemanticsRunner.Run(astProgram,
                compilerSettings.CodeGenerationTarget == CodeGenerationTarget.Dotnet
                    ? FunctionIndexingStrategy.Splitted
                    : FunctionIndexingStrategy.United);

            if (compilerSettings.PrintAstTree)
            {
                TreeConsolePrinter tp = new TreeConsolePrinter();
                tp.Print(astProgram);
            }

            if (compilerSettings.CodeGenerationTarget == CodeGenerationTarget.Java)
            {
                JasminCodeGenerator generator = new JasminCodeGenerator();
                generator.GenerateCode(astProgram);
                generator.SaveFiles();
                RunJasminBuildScript();
            }
            else if (compilerSettings.CodeGenerationTarget == CodeGenerationTarget.Dotnet)
            {
                CodeGenerator cg = new CodeGenerator("AssTest", astProgram);
            }
            //Helpers.FilePrinter.WriteTextToFile(generator.CodeListing, "output.j");
            //Console.WriteLine(generator.CodeListing);
            //RunJasminBuildScript();
        }

        private static ITree RunSyntaxAnalysys(string arg)
        {
            ICharStream input = new ANTLRFileStream(arg);
            MathLangLexer lexer = new MathLangLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            MathLangParser parser = new MathLangParser(tokens);
            return (ITree) parser.execute().Tree;
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
            startInfo.FileName = Path.Combine(CompilerSettings.HomeDirectory, "run_jasmin.bat");
#endif
            //            startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            //            startInfo.Arguments = "-jar %JASMIN_PATH% *.j >jasmin_buildlog.txt 2>&1";
            process.StartInfo = startInfo;
            process.Start();
        }

        private static void ProcessArguments(IEnumerable<string> args, out IEnumerable<string> files,
            out IEnumerable<string> parameters)
        {
            var enumerable = args as IList<string> ?? args.ToList();
            files = enumerable.Where(s => !s.Contains("--")).ToList();
            parameters = enumerable.Where(s => s.Contains("--")).ToList();
        }
    }
}