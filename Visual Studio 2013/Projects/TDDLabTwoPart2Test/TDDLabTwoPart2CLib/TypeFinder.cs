using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLabTwoPart2CLib
{
    public class TypeFinder
    {

        public string StringTypeFinder(string value)
        {

            if (value.All(char.IsLetter))
            {
                return "Word"; 
            }

            if (value.All(char.IsDigit))
            {
                return "Number";
            }


            return "Write Something else";
        }

    

        
    }
}
