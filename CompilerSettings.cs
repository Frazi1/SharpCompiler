using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MathLang.Extensions;

namespace MathLang
{
    public class CompilerSettings
    {

        private static string DuplicateSetting(string setting) => $"Parameter {setting} was already specified";

        public static string CurrentDirectory => Directory.GetCurrentDirectory();
        public static string HomeDirectory => AppDomain.CurrentDomain.BaseDirectory;
        public static string LibsFolderPath => Path.Combine(HomeDirectory, LibsFolderName);
        public static string NativesFolderPath => Path.Combine(LibsFolderPath, NativesFolderName);
        public static string DotNetNativesPath => Path.Combine(NativesFolderPath, DotNetFolderName);
        public static string JavaNativesPath => Path.Combine(NativesFolderPath, JavaFolderName);

        public const string NJCLibName = "NJCLib.cs";
        public const string LibsFolderName = "libs";
        public const string NativesFolderName = "Natives";
        public const string DotNetFolderName = "dotnet";
        public const string JavaFolderName = "java";

        public IEnumerable<string> FilesPaths { get; private set; }
        public CodeGenerationTarget CodeGenerationTarget { get; private set; }
        public bool PrintSyntaxTree { get; private set; }
        public bool PrintAstTree { get; private set; }
        public bool ShowJasminBytecode { get; private set; }

        public string NJCLibPath { get; private set; }
        public bool NJCLibFound => !string.IsNullOrEmpty(NJCLibPath);

        public static CompilerSettings ParseCompilerSettings(IEnumerable<string> files, IEnumerable<string> parameters)
        {
            CompilerSettings compilerSettings = new CompilerSettings();
            ProcessFiles(files, compilerSettings);

            parameters.ForEach(parameter =>
            {
                if (parameter.Contains("--target")) ProcessTargetSetting(compilerSettings, parameter);
                if (parameter.Contains("--print")) ProcessPrintSetting(compilerSettings, parameter);
            });
            return compilerSettings;
        }

        private static void ProcessFiles(IEnumerable<string> files, CompilerSettings compilerSettings)
        {
            var filesList = files.ToList();
            if (filesList.Count == 0)
                throw new Exception("Select a file");
            var duplicateNames = filesList.GetDuplicatedItems().ToList();
            if (duplicateNames.Any())
                throw new Exception($"Files ({string.Join(", ", duplicateNames)}) were specified more than once");

            if (filesList.Any(s => s.Contains(NJCLibName)))
            {
                compilerSettings.NJCLibPath = filesList.Find(s => s.Contains(NJCLibName));
                filesList.Remove(compilerSettings.NJCLibPath);
            }

            if (!compilerSettings.NJCLibFound)
                FindNJCLib(compilerSettings);

            compilerSettings.FilesPaths = filesList;
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

        private static void FindNJCLib(CompilerSettings settings)
        {
            FindNJCLibInternal(CurrentDirectory);
            if(!settings.NJCLibFound)
                FindNJCLibInternal(HomeDirectory);

            void FindNJCLibInternal(string path)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                var filesInfos = directoryInfo.GetFiles(NJCLibName);
                settings.NJCLibPath = filesInfos.FirstOrDefault()?.FullName;

                if (!settings.NJCLibFound)
                {
                    var libsDir = directoryInfo.GetDirectories(LibsFolderName);
                    settings.NJCLibPath = libsDir.FirstOrDefault()
                        ?.GetFiles(NJCLibName).FirstOrDefault()
                        ?.FullName;
                }
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