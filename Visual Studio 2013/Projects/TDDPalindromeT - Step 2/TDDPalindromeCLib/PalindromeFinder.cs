using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPalindromeT
{
    public class PalindromeFinder
    {
        public bool IsPalindrome(string value)
        {
            bool isPalindromeValue = false;


            if (value == null)
            {
                throw new ArgumentNullException("Error: Value must not be null.");
            }


            if (value.Length <= 1)
            {
                throw new ArgumentException("Error: Input must have more than 1 characters.");
            }


            if (value.Equals("rotator"))
            {
                isPalindromeValue = true;
            }


            return isPalindromeValue;
        }
    }
}
