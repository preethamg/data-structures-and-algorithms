using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_using_Iteration
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter The array in increasing order");
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
                int n = arr.Length;
                while (true)
                {
                    Console.WriteLine("Please Enter the key to search in array");
                    int key = Convert.ToInt32(Console.ReadLine());
                    int index = BinarySearch(arr, 0, n - 1, key);
                    if (index != -1)
                    {
                        Console.WriteLine("Key Found at {0}th index in array", index + 1);
                    }
                    else
                    {
                        Console.WriteLine("Key Not Found in array");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int BinarySearch(int[] arr, int left, int right, int key)
        {
            try
            {
                while (left <= right)
                {
                    int mid = (left + right) / 2;

                    if (key == arr[mid])
                    {
                        return mid;
                    }
                    else if (key < arr[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}

