using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;


            string normalizedInput = input.Replace(" ", "").ToLower();

            char[] charArray = normalizedInput.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);

            return normalizedInput == reversedInput;
        }
    }
}