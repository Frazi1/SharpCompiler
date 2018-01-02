
static class Main
{
    //static int[] Strs = new int[3];

    static void Main()
    {
        Library.PrintInt(1);
        Main.Meow(5);
    }

    static void Meow(int i)
    {
        Library.PrintInt(i);
    }
}