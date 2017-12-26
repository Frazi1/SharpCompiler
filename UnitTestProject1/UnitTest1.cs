using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int l = 10;
            int[] a = new int[l];
            for (int i = 0; i < l; i = i + 1)
                a[i] = l - i;
            
            for (int i = 0; i < l; i = i + 1)
            {
                for (int j = 0; j < l - 1; j = j + 1)
                {
                    if (a[j] > a[j+1])
                    {
                        Swap(a, j, j + 1);
                    }
                }
            }
            Test(a);

        }


        static void Swap(int[] arr, int a, int b)
        {
            int t = arr[a];
            arr[a] = arr[b];
            arr[b] = t;
        }

        static void Test(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i] > arr[i+1])
                    throw new Exception(); 
            }
        }
    }
}
