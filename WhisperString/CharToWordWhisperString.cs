//Author Daniels module

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhisperString
{
    public class CharToWordWhisperString : IWhisperString
    {

        public string ManipulateMessage(string message)
        {

            if (message == null)
                throw new ArgumentNullException("Message is null.");
            if (message.Trim().Equals(""))
                throw new ArgumentException("Message is empty.");

            string result = message.Replace("a", "apa").Replace("b", "bebis").Replace("c", "cykel")
            .Replace("d", "dremmel").Replace("i", "ii");

            return result;
        }
    }
}
