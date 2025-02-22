using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3
{
    internal class Even_OddChecker
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            bool isEven(int number) => number % 2 == 0;
            bool isOdd(int number) => number % 2 != 0;


            try
            {
                int number = int.Parse(input);
                if (isEven(number))
                    Console.WriteLine("The number is even");
                else Console.WriteLine("The number is odd");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid input");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
