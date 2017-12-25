
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
            myArr[i] = len - i;
            i = i + 1;
        }

        

        ArrayPrint(myArr, len);

        //Change(myArr, 0, myArr, len - 1);

        QuickSort(myArr, 0, len - 1);

        ArrayPrint(myArr, len);
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
        Console.WriteLineChar('-');

        for (int t = 0; t < len; t = t + 1)
        {
            Console.WriteLineInt(myArr[t]);
        }

        Console.WriteLineChar('-');

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
    static void QuickSort(int[] arr, int first, int last)
    {
        if (last > first)
        {
            int position = ReplaceElementsAndReturnPosition(arr, first, last);
            QuickSort(arr, first, position - 1);
            QuickSort(arr, position + 1, last);
        }
    }
    static int ReplaceElementsAndReturnPosition(int[] arr, int first, int last)
    {
        int key = arr[last];
        int lastPositionOfTheLeast = first - 1;

        //for (int i = first; i < last; i++)
        //{
        //    if (arr[i] < key)
        //    {
        //        lastPositionOfTheLeast = lastPositionOfTheLeast + 1;
        //        Change(arr, i, arr, lastPositionOfTheLeast);
        //    }
        //}

        int i = first;

        while ( i < last)
        {
            if (arr[i] < key)
            {
                lastPositionOfTheLeast = lastPositionOfTheLeast + 1;
                Change(arr, i, arr, lastPositionOfTheLeast);
            }

            i = i + 1;
        }

        lastPositionOfTheLeast = lastPositionOfTheLeast + 1;
        Change(arr, last, arr, lastPositionOfTheLeast);
        return lastPositionOfTheLeast;
    }

    static void Change(int[] a1, int i1, int[] a2, int i2)
    {
        int temp = a1[i1];
        a1[i1] = a2[i2];
        a2[i2] = temp;
    }
}
