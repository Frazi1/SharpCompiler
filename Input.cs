
class Main
{
    static void Main()
    {
        
    }
}

static class ValeraTest
{
    static void Main()
    {
        
    }
    static char Tom = 't';
    static int Cat = 8 + Tom;

    //static int GoodCat(int alla)
    //{
    //    alla = Tom;
    //    return Tom;
    //}

    ////return cast check & cast check
    //static char BadCat()
    //{
    //    return -7;
    //}

    ////array check
    static void Method(int[] funArr)
    {
        int[] arr = new int[4];
        arr[(6 - 5)] = Cat;
        arr[Cat] = 'r';

        //char, not int
        //arr['8'] = Cat;
    }

    static int Leaf(int p)
    {
        ////call not existing func
        //lalala(p);

        //leaf returns void
        int test = Leaf(p + 4);
        //char =  Console.ReadChar();

        ////call func with wrong arguments
        //Leaf('u');
        return 1;
    }

    //static int ReadTest( int kkk, char ppp)
    //{
    //    int k;
    //    int oo;

    //    oo = kkk + ReadTest(k, ppp);
        
    //    return Console.ReadChar();
    //}
}
