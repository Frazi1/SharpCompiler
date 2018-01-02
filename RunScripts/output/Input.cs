static class Main
{    //static int[] Strs = new int[3];

    static void Main()
    {
        Library.PrintInt(1);
        Cat.Meow('p');
        Meow();
    }

    static void Meow()
    {
        Library.PrintInt(9);
    }
}

static class Cat
{
    static void Meow(char uiui)
    {
        Library.PrintChar(uiui);
    }
}