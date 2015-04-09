using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperMessage;

namespace SNWhisperConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    IWhisperString whisperStr = new WhisperString();
                    IWhisperString whisperNS = new WhisperSecondNext();
                    Console.WriteLine("Enter a message: ");
                    var message = Console.ReadLine();
                    string result=message;
                    //result = whisperStr.ManipulateMessage(message);
                    result = whisperNS.ManipulateMessage(result);
                    Console.WriteLine("Entered message: {0} \nManipul message: {1}", message, result);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                //Console.ReadLine();
            }
        }
    }
}
