using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3
{
    internal class BasicDivisionProgram
    {
        public static void DivisionProgram()
        {
            Console.WriteLine("Enter the first integer");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second integer");
            string input2 = Console.ReadLine();

            try
            {
                int number1 = int.Parse(input1);
                int number2 = int.Parse(input2);

                int result = Division(number1, number2);
                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int Division(int num1, int num2)
        {
            //if (num2 == 0)
            //{
            //    throw new DivideByZeroException();
            //}
            return num1 / num2;
        }
    }
}
