using System;
using System.Collections.Generic;
using System.Linq;
using MathLang.Extensions;

namespace MathLang
{
    public class CompilerSettings
    {
        private static string DuplicateSetting(string setting) => $"Parameter {setting} was already specified";

        public IEnumerable<string> FilesPaths { get; private set; }
        public CodeGenerationTarget CodeGenerationTarget { get; private set; }
        public bool PrintSyntaxTree { get; private set; }
        public bool PrintAstTree { get; private set; }
        public bool ShowJasminBytecode { get; private set; }

        public static CompilerSettings ParseCompilerSettings(IEnumerable<string> files, IEnumerable<string> parameters)
        {
            CompilerSettings compilerSettings = new CompilerSettings {FilesPaths = files.ToList()};
            parameters.ForEach(parameter =>
            {
                if (parameter.Contains("--target")) ProcessTargetSetting(compilerSettings, parameter);
                if (parameter.Contains("--print")) ProcessPrintSetting(compilerSettings, parameter);
            });
            return compilerSettings;
        }

        private static void ProcessTargetSetting(CompilerSettings settings, string targetSetting)
        {
            if (settings.CodeGenerationTarget != CodeGenerationTarget.None)
                throw new Exception("--target setting was already specified");
            switch (targetSetting)
            {
                case "--target=net":
                    settings.CodeGenerationTarget = CodeGenerationTarget.Dotnet;
                    break;
                case "--target=java":
                    settings.CodeGenerationTarget = CodeGenerationTarget.Java;
                    break;
                default:
                    throw new Exception($"target setting does not support value {targetSetting}");
            }
        }

        private static void ProcessPrintSetting(CompilerSettings settings, string printSettting)
        {
            switch (printSettting)
            {
                case "--print-ast":
                    if (settings.PrintAstTree) throw new Exception(DuplicateSetting(printSettting));
                    settings.PrintAstTree = true;
                    break;
                case "--print-syntax":
                    if (settings.PrintSyntaxTree) throw new Exception(DuplicateSetting(printSettting));
                    settings.PrintSyntaxTree = true;
                    break;
            }
        }
    }

    public enum CodeGenerationTarget
    {
        None = 0,
        Java,
        Dotnet
    }
}