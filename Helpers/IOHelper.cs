using System.IO;
using MathLang.Extensions;

namespace MathLang.Helpers
{
    public static class IOHelper
    {
        public static void CopyDirItems(string sourceDir, string destinationDir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sourceDir);
            var files = directoryInfo.GetFiles();

            files.ForEach(file =>
            {
                File.Copy(file.FullName, Path.Combine(destinationDir, file.Name), true);
            });
        }
    }
}