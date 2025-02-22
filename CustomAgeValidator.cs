using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3
{
    internal class CustomAgeValidator
    {
        public static void AgeValidator()
        {
            try
            {
                Console.WriteLine("Enter your age:");
                string input = Console.ReadLine();
                int age = ValidateAge(input);
                Console.WriteLine("Your age is " + age);
            }
            catch (AgeOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static int ValidateAge(string input)
        {
            if (!int.TryParse(input, out int age))
                throw new FormatException("Input is not a valid integer.");
            

            if (age < 0 || age > 150)
                throw new AgeOutOfRangeException("Age must be between 0 and 150");
    
        return age;
        }
    }

    public class AgeOutOfRangeException : Exception
    {
        public AgeOutOfRangeException(string message) : base(message) { }
    }
}
