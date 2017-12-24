
static class ValeraTest
{
    //static char Tom = 't';
    //static int Cat = 8 + Tom;

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
    //static void Method()
    //{
    //    bool kkkk = 1 < 2;

    //    int[] arr = new int[4];
    //    arr[(6 - 5)] = Cat;
    //    arr[Cat] = 'r';

    //    //char, not int
    //    //arr['8'] = Cat;
    //}

    static void Main()
    {
        Console.WriteLineInt(790);
        Console.WriteLineChar('i');
        Console.WriteLineBool(true);
        Console.WriteLineBool(false);

        ////call not existing func
        //lalala(p);

        ////leaf returns void
        //int test = Leaf(p + 4);

        ////call func with wrong arguments
        //Leaf('u');
        int len = GetLen(5);

        int[] myArr = new int[len];

        int i = 0;

        while (i < len)
        {
            myArr[i] = i+1;
            i = i + 1;
        }

        ArrayPrint(myArr, 5);
    }

    static int GetLen(int lll)
    {
        return lll;
    }

    static void ArrayPrint(int[] myArr, int len)
    {
        int i = 0;
        while (i < len)
        {
            Console.WriteLineInt(myArr[i]);
            i = i + 1;
        }
        //Console.WriteLineInt(uiuiui);

        //char helen = 'h';

        //Console.WriteLineInt(helen);

        //helen = 'H';
        //Console.WriteLineInt(helen);


        //myArr[0] = 78 + 2;
        //int klkl = myArr[0];
        //Console.WriteLineInt(klkl);
        //Arraprint(myArr);
    }

    static void Arraprint(int[] arra)
    {
        Console.WriteLineInt(arra[0]);

        if (1 < 2)
        {
            Console.WriteLineChar('t');
        }
        else
        {
            Console.WriteLineChar('f');
        }

        Console.WriteLineBool(1<2);
        Console.WriteLineBool(1 > 2);
        Console.WriteLineBool(1 <= 2);
        Console.WriteLineBool(1 >= 2);
        Console.WriteLineBool(1 == 2);
        Console.WriteLineBool(1 == 1);
        Console.WriteLineBool(1 != 2);
    }

    //static int ReadTest( int kkk, char ppp)
    //{
    //    int k;
    //    int oo;

    //    oo = kkk + ReadTest(k, ppp);

    //    return Console.ReadChar();
    //}
}
