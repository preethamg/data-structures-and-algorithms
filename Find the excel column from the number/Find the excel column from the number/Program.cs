using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_excel_column_from_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number to be converted");
            int num = Convert.ToInt32(Console.ReadLine());
            ExcelColumn(num);
            Console.ReadKey();
        }

        static void ExcelColumn(int number)
        {
            List<char> arr = new List<char>();
            while (number > 0)
            {
                int rem = number % 26;

                if (rem == 0)
                {
                    arr.Add('Z');
                    number = (number / 26) - 1;
                }
                else
                {
                    arr.Add(Convert.ToChar((rem - 1) + 'A'));
                    number = number / 26;
                }
            }
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
