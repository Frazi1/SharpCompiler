class Main
{
    static int Valera = 22;
    static string[] Strs = new string[3];
    
    static void Main(string[] args)
    {
          TestClass.Test();
//        Strs[0] = "Privet";
//        Strs[1] = "Valera";
//        Strs[2] = "Girl";
//        Valera = 13;
//        Library.PrintInt(Valera);
//        for (int i = 0; i < 3; i=i+1)
//        {
//            Library.PrintString(Strs[i]);
//        }
        //int i = 0;
        //while (i < 10)
        //{
        //    Library.PrintInt(i);
        //    if(i ==10)
        //    return;
        //}

        //int l = 10;
        //int[] a = new int[l];
        //for (i = 0; i < l; i = i + 1)
        //{
        //    a[i] = l - i;
        //    Library.PrintInt(i);
        //}

        //PrintIntArray(a, l);
        //BubbleSort(a, l);
        //Library.PrintString("Sorted:");
        //PrintIntArray(a, l);



        //Library.PrintInt(Fact(20));
        //Library.PrintInt(Fibbonacchi(13));
        //Library.PrintString("HUNDRED");
        //Library.PrintInt(Test.GetAHundred());
    }

    //static void TestReturn(bool b)
    //{
    //    int[] i = new int[1];
    //    if (b)
    //    {
    //        return i;
    //    }
    //    Library.PrintString("not returned");
    //}

    //static void Swap(int[] arr, int a, int b)
    //{
    //    int t = arr[a];
    //    arr[a] = arr[b];
    //    arr[b] = t;
    //}

    //static void BubbleSort(int[] a, int l)
    //{
    //    for (int i = 0; i < l; i = i + 1)
    //        for (int j = 0; j < l - 1; j = j + 1)
    //            if (a[j] > a[j + 1])
    //                Swap(a, j, j + 1);
    //}

    //static void PrintIntArray(int[] arr, int lenght)
    //{
    //    for (int i = 0; i < lenght; i = i + 1)
    //    {
    //        Library.PrintInt(arr[i]);
    //    }
    //}

    //static int Fibbonacchi(int n)
    //{
    //    if (n > 2)
    //    {
    //        int i = Fibbonacchi(n - 1) + Fibbonacchi(n - 2);
    //        //Library.PrintInt(i);
    //        return i;
    //    }
    //    //Library.PrintInt(1);
    //    return 1;
    //}

    //static int Fact(int n)
    //{
    //    if (n == 0)
    //        return 1;
    //    return n * Fact(n - 1);
    //}

    //static void Compare(int a, int b)
    //{
    //    if (a < b)
    //    {
    //        Library.PrintString("a < b");
    //    }
    //    else if (a > b)
    //    {
    //        Library.PrintString("a > b");
    //    }
    //    else
    //    {
    //        Library.PrintString("a==b");
    //    }

    //}

    //static bool boolT(bool a, bool b)
    //{
    //    return b || a;
    //}

    //static int IntTest()
    //{
    //    return 1 + 21 * 3;
    //}

    //static bool TestChar()
    //{
    //    bool t1 = 10 != 15;
    //    bool t2 = 1 == 2;
    //    bool t3 = 1 <= 2;
    //    bool t4 = 1 >= 2;
    //    bool t5 = 1 > 2;

    //    return true == false;
    //}
}

//static class Test
//{
//    static int GetAHundred()
//    {
//        return 100;
//    }
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
