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
            while (true)
            {
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1: Convert Page Number to Excel Sheet Column");
                Console.WriteLine("2: Convert Excel Sheet Column to Page Number");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option < 0 || option > 2)
                {
                    Console.WriteLine("Invalid Option Please Try Again");
                }
                else
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please Enter the number to be converted");
                            int num = Convert.ToInt32(Console.ReadLine());
                            NumberToExcelColumn(num);
                            break;
                        case 2:
                            Console.WriteLine("Please Enter Excel Sheet Number to be converted");
                            string column = Console.ReadLine().ToUpper();
                            ExcelColumnToNumber(column);
                            break;
                    }
                }
            }

            Console.ReadKey();
        }

        static void NumberToExcelColumn(int number)
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

        public static void ExcelColumnToNumber(string column)
        {
            int num = 0;
            int len = column.Length;
            for (int i = 0; i < len; i++)
            {
                num += Convert.ToInt32((column[len-i-1] - 'A' + 1) * Math.Pow(26, i));
            }
            Console.WriteLine(num);
        }

    }
}
