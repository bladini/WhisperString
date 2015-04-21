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

            string result = message.Replace("a", "apa").Replace("b", "bebis").Replace("c", "cykel")
            .Replace("d", "dremmel").Replace("i", "ii");

            return result;
        }
    }
}
