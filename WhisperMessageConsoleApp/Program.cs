//Author: Tobias Bladini
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperString;

namespace WhisperStringConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inProgress = true;
            while (inProgress)
            {
                try
                {
                    IWhisperString whisperStr = new RhymeWhisperString();
                    Console.WriteLine("Enter a message: ");
                    var message = Console.ReadLine();
                    if (message == "q")
                        break;
                    var result = whisperStr.ManipulateMessage(message);
                    Console.WriteLine("\nEntered message:     {0} \nManipulated message: {1}\n", message, result);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
