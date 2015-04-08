using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLabTwo
{
    public class TestFinder
    {
        public int CountStringLenght(string value)
        {
            int result = 0;
            foreach (char c in value)
            {
                if (!char.IsWhiteSpace(c))
                {
                    result++;
                }
            }

            return result;
        }

    }
}
