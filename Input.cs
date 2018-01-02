
static class ValeraTest
{

    static void Main()
    {
        //Console.WriteLineInt(790);
        //Console.WriteLineChar('i');
        //Console.WriteLineBool(true);
        //Console.WriteLineBool(false);

        int len = AnnaTest.GetLen(5);

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



    static void ArrayPrint(int[] myArr, int len)
    {
        int i = 0;

        for (int t = 0; t < len; t = t + 1)
        {
            Console.WriteLineInt(myArr[t]);
        }

        Console.WriteLineChar('-');

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

static class AnnaTest
{
    static int GetLen(int lll)
    {
        return lll;
    }
}
