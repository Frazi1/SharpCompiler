static extern class Library
{
    [JavaRef("Library/printString")]
    static extern void PrintString(string s);
    
    [JavaRef("Library/printInt")]
    static extern void PrintInt(int i);
}

class Main
{
    static void Main(string[] args)
    {
        //int a = 13;
        //Library.PrintString("1");
        //Library.PrintInt(2*2+a);
        Library.PrintInt( Main.TestMult(3,3) - Main.TestMult(2,3));
    }

    static int TestMult(int a, int b)
    {
        //Library.PrintInt(a * b);
        return a * b;
        //string mySuperString = "MY SUPER STRING";
        //Library.PrintString(mySuperString);
    }
}

//static class Test
//{
    
//}

//static class ValeraTest
//{
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
    //static void Method(int funArr, char test2)
    //{
    //    int[] arr = new int[4];
    //    arr[(6 - 5)] = Cat;
    //    arr[Cat] = 'r';

    //    //char, not int
    //    //arr['8'] = Cat;
    //}

    //static int Leaf(int[] p)
    //{
    //    ////call not existing func
    //    //lalala(p);

    //    //leaf returns void
    //    int test = Leaf(new int[3]);
    //    //char =  Console.ReadChar();

    //    ////call func with wrong arguments
    //    //Leaf('u');
    //    return 1;
    //}

    //static int ReadTest( int kkk, char ppp)
    //{
    //    int k;
    //    int oo;

    //    oo = kkk + ReadTest(k, ppp);
        
    //    return Console.ReadChar();
    //}
//}
