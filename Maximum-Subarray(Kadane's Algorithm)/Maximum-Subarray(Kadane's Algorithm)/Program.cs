using System;

namespace Maximum_Subarray_Kadane_s_Algorithm_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int testCaseCount = Convert.ToInt32(Console.ReadLine());
                while (testCaseCount-- > 0)
                {
                    int arrSize = Convert.ToInt32(Console.ReadLine());
                    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
                    int maxEndingHere = 0; int maxEndingSoFar = Int32.MinValue;

                    for (int i = 0; i < arrSize; i++)
                    {
                        //add elements in array in iteration to maxEndingSoFar
                        maxEndingHere += arr[i];

                        //if we find any sum greater than the current max sum then make that max sum
                        if (maxEndingSoFar < maxEndingHere)
                        {
                            maxEndingSoFar = maxEndingHere;
                        }

                        //if maxEndingSoFar is less than zero then we need to reset it back to zero
                        if (maxEndingHere < 0)
                        {
                            maxEndingHere = 0;
                        }

                    }

                    Console.WriteLine(maxEndingSoFar);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
