using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class IntegerExtensions
    {
        public static int Factorial(int num)
        {
            if (num < 0)
            {
                return -1;
            }

            else if (num == 1 || num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }

        }

    }
}
