using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLabTwoPartThree
{
    public class NextPalidromeFinder
    {
        public int NextPalindrome(int value)
        {
            throw new NotImplementedException();
        }

        public bool NumberPalindrome(string value)
        {

            if (value.Length <= 2)
            {
                throw new ArgumentException("Error your number is to low write something over 100");
            }

            if (value.Length >= 4)
            {
                throw new ArgumentException("Error you number is to high write something lower than 999");
                
            }

            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            var reversedValue = new string(charArray);

            return (reversedValue == value);

        }

       
    


     
    }

}
