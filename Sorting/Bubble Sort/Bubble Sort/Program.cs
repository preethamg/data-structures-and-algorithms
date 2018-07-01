using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the contents of array");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
            Bubble_Sort(arr, arr.Length);
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }

        static int[] Bubble_Sort(int[] arr,int n)
        {
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
            return arr;
        }

        static void Swap(int [] arr,int index1,int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
