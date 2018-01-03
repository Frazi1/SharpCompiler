static class Main
{

    static void Main(string[] args)
    {
        int len = AnnaTest.GetLen(9);

        AnnaTest.PrintHelen();

    }

}

static class AnnaTest
{
    static int Helen = 89;

    static int GetLen(int lll)
    {


        Helen = lll;

        return lll;
    }

    static void PrintHelen()
    {
        NJCLib.PrintInt(42);
        NJCLib.PrintInt(Helen);
    }
}
