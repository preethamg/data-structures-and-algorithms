using System;

namespace Fibo_with_memoization
{
    class Program
    {
        static int[] fib;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("****************************************");
                Console.WriteLine("Please Enter the number to find the fibo");
                Console.WriteLine("**Note if you are using the method without memoization, then a small input is recommended to avoid the time delay");
                int n = Convert.ToInt32(Console.ReadLine());

                //initializing the static array with the size n
                fib = new int[n + 1];
                Console.WriteLine("Please Enter 1 for without Memoization and 2 for with Memoization");
                int choice = Convert.ToInt32(Console.ReadLine());

                var watch = new System.Diagnostics.Stopwatch();

                if (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Bad Choice :(");
                }
                else if (choice == 1)
                {
                    watch.Start();
                    Console.WriteLine($"Fibonacci of {n} without Memoization :{FibWithoutMemoization(n)}");
                    watch.Start();
                    Console.WriteLine($"Time taken for execution is {(watch.ElapsedMilliseconds) * 0.001} sec");
                }
                else if (choice == 2)
                {
                    watch.Start();
                    Console.WriteLine($"Fibonacci of {n} with Memoization :{FibWithMemoization(n)}");
                    watch.Start();
                    Console.WriteLine($"Time taken for execution is {(watch.ElapsedMilliseconds) * 0.001} sec");
                }
                Console.ReadKey(); 
            }
        }

        static int FibWithoutMemoization(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n <= 2)
            {
                return 1;
            }
            else
                return FibWithoutMemoization(n - 1) + FibWithoutMemoization(n - 2);
        }

        static int FibWithMemoization(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n <= 2)
            {
                return 1;
            }
            else if (fib[n] > 0)
            {
                return fib[n];
            }
            else
            {
                return fib[n] = FibWithMemoization(n - 1) + FibWithMemoization(n - 2);
            }
        }

    }
}
