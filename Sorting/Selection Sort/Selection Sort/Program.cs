using System;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the contents of array");
            var arr = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
            Console.WriteLine();
            foreach (var item in Selection_Sort(arr, arr.Length))
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

        static int[] Selection_Sort(int[] arr,int n)
        {
            for (int i = 0; i < n-1; i++)
            {
                int min = i;
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                Swap(arr, i, min);
            }
            return arr;
        }

        static void Swap(int[] arr,int ind1,int ind2)
        {
            int temp = arr[ind1];
            arr[ind1] = arr[ind2];
            arr[ind2] = temp;
        }
    }
}
