using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3
{

    class FindMaximum
    {
        public static void Maximum()
        {

            Func<int, int, int> max = (a, b) => a > b ? a : b;

            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int maximum = max(firstNumber, secondNumber);

            Console.WriteLine($"The maximum of {firstNumber} and {secondNumber} is: {maximum}");
        }
    }
}
