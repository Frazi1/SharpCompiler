static extern class Library
{
    //[JavaRef("Library/printString")]
    //static extern void PrintString(string s);

    [JavaRef("Library/printInt")]
    [DotNetRef("Library/PrintInt")]
    static extern void PrintInt(int i);

    [JavaRef("Library/printBool")]
    static extern void PrintBool(bool b);

    [JavaRef("Library/printChar")]
    static extern void PrintChar(char c);
}