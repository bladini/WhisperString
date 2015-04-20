using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDLabTwoPart2CLib;

namespace TDDLabTwoPartTwo
{
    class Program
    {
    
        static void Main(string[] args)
        {
            TypeFinder t = new TypeFinder();
            while (true)
            {
                Console.Write("Enter a word: ");
                var value = Console.ReadLine();
                if (value == "q")
                {
                    break;  
                }
              
                    Console.WriteLine(t.StringTypeFinder(value));
                }
            

              
                
            }
        }
    }

