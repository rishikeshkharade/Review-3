using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Review_3;
namespace Tests
{
    public class PalindromeCheckerTests
    {
        private PalindromeChecker palindromeCheck;

        [SetUp]
        public void Setup()
        {
            palindromeCheck = new PalindromeChecker();
        }

        [Test]
        public void IsPalindrome()
        {

            string input = "madam";


            bool result = palindromeCheck.IsPalindrome(input);


            Assert.IsTrue(result);
        }


        [Test]
        public void IsNotPalindrome()
        {

            string input = "hello";


            bool result = palindromeCheck.IsPalindrome(input);


            Assert.IsFalse(result);
        }
    }
}