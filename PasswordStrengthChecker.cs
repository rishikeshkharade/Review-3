using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review_3
{
    internal class PasswordStrengthChecker
    {
        public static void MainMethod()
        {
            Console.WriteLine("Enter a password to check its strength: ");
            string password = Console.ReadLine();

            if (IsStrongPassword(password))
            {
                Console.WriteLine("The password is strong");
            }
            else
            {
                Console.WriteLine("The password is weak");
            }


        }

        static bool IsStrongPassword(string password)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");

            return regex.IsMatch(password);
        }
    }
}
