using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the array contents separated by space");
            try
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Quick_Sort(arr, 0, arr.Length - 1);
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Quick_Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = Partition(arr, start, end);
                Quick_Sort(arr, start, partitionIndex - 1);
                Quick_Sort(arr, partitionIndex + 1, end);
            }
        }

        static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int partitionIndex = start;

            for (int i = start; i <= end; i++)
            {
                if (arr[i] < pivot)
                {
                    Swap(arr, i, partitionIndex);
                    partitionIndex++;
                }
            }
            Swap(arr, end,partitionIndex);
            return partitionIndex;
        }

        static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }

}
