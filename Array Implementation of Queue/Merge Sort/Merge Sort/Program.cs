using System;


namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter the array to sort");
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
                DivideArray(arr);
                Console.WriteLine();
                Console.WriteLine("Sorted Array");
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

        static void DivideArray(int[] arr)
        {
            try
            {
                int n = arr.Length;
                if (n < 2)
                {
                    return;
                }
                else
                {
                    int mid = n / 2;

                    int[] leftArr = new int[mid]; int[] rightArr = new int[n - mid];

                    for (int i = 0; i < mid; i++)
                    {
                        leftArr[i] = arr[i];
                    }

                    for (int i = mid; i < n; i++)
                    {
                        rightArr[i - mid] = arr[i];
                    }

                    DivideArray(leftArr);
                    DivideArray(rightArr);
                    SortnMerge(arr, leftArr, rightArr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int[] SortnMerge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            int leftLength = left.Length; int rightlength = right.Length; int n = arr.Length;
            while (i < leftLength && j < rightlength)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < leftLength)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < rightlength)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
            return arr;
        }
    }
}
