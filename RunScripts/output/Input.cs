static class Main
{

    static void Main(string[] args)
    {
        int len = 10;

        int[] myArr = new int[len];

        int i = 0;

        while (i < len)
        {
            myArr[i] = len - i;
            i = i + 1;
        }



        ArrayPrint(myArr, len);

        QuickSort(myArr, 0, len - 1);

        ArrayPrint(myArr, len);

        int result = BinarySearch(myArr, 0, len - 1, 6);
        NJCLib.PrintChar('h');
        NJCLib.PrintInt(result);
    }



    static void ArrayPrint(int[] myArr, int len)
    {
        int i = 0;

        for (int t = 0; t < len; t = t + 1)
        {
            NJCLib.PrintInt(myArr[t]);
        }

        NJCLib.PrintChar('-');

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

        while (i < last)
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

    static int BinarySearch(int[] arr, int l, int r, int x)
    {
        if (r >= l)
        {
            int mid = l + (r - l) / 2;
            if (arr[mid] == x)
            {
                return mid;
            }
            if (arr[mid] > x)
            {
                return BinarySearch(arr, l, mid - 1, x);
            }
            return BinarySearch(arr, mid + 1, r, x);
        }
        return -1;
    }
}

