using System.IO;

namespace MathLang.Helpers
{
    public static class FilePrinter
    {
        public static void WriteTextToFile(string text, string filePath)
        {
            var writer = new StreamWriter(filePath);
            writer.Write(text);
            writer.Flush();
            writer.Close();
        }
    }
}