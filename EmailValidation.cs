using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review_3
{
    internal class EmailValidation
    {
        public static void EmailValidationMain()
        {
            Console.WriteLine("Enter an email address to validate: ");
            string email = Console.ReadLine();

            if (IsValidEmail(email)) {
                Console.WriteLine("The email address is valid.");
            }
            else
            {
                Console.WriteLine("The email address is invalid.");
            }

        }

        static bool IsValidEmail(string email)
        {
            Regex regex = new Regex(@"^[a-z0-9._-]+@[a-z]+\.[a-z]{2,}$");
            return regex.IsMatch(email);
        }

}
}
