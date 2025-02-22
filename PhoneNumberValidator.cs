using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review_3
{
    internal class PhoneNumberValidator
    {
        public static void PhoneNumber()
        {
            Console.WriteLine("Enter a phone number to validate:");
            string phoneNumber = Console.ReadLine();

            if (IsValidPhoneNumber(phoneNumber))
            {
                Console.WriteLine("The phone number is valid.");
            }
            else
            {
                Console.WriteLine("The phone is invalid. The format is +91-1234567890 or 123-456-7890.");
            }
        }

        static bool IsValidPhoneNumber(string phone_number) { 
        Regex regex = new Regex(@"^(\+91-\d{10}|(\d{3}-\d{3}-\d{ 4}))$");
            return regex.IsMatch(phone_number);


        }
    }
}
