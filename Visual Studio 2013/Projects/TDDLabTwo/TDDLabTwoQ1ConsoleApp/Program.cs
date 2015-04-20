using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFinder t = new TestFinder();


            while (true)
            {


                Console.Write("Enter a word: ");
                var value = Console.ReadLine();
                if (value == "q")
                {
                    break;
                }
                Console.WriteLine(t.CountStringLenght(value));




            }

            
        }
    }
}
