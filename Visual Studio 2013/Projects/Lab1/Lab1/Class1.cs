using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class StringExtension
    {
       
       public static string ConcatArrayWithSpace(string [] array)
        {

            return String.Join(" ", array); ;
        }

        public static string Capitalize(string capi)
        {

            var output = "";
            foreach (var item in capi)
            {
                if (char.IsPunctuation(item))
                {
                    output = output + "_";  
                }
                else if(!char.IsWhiteSpace(item))
                {
                    output = output + item;
                }
            }

            return output.ToUpper();
        }


        public static string UpperCaseFirstEach(string Upper)
        {

            if(string.IsNullOrEmpty(Upper))
            {
                return string.Empty;
            }

            char[] a = Upper.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);

        }

        public static int Average (int y, int x)
        {

            int average = (x + y) / 2;

            return average;
        }
    }
}
