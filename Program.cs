using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, 22, 43, 23, 2, 0, 2 };
            int l = 1;
            int high = arr.Length;

            for (int i = l; i < high; i++)
            {
                int key = arr[i];
                int j = i-1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            
            for (int i = 0; i < high; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
