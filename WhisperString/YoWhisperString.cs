// Author: Timmi Nikqi
//
// Date: 21/04-2015
//
// Class: SUW-14

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhisperString
{
    public class YoWhisperString : IWhisperString
    {
        public string ManipulateMessage(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("Message is null");
            }
            if (message.Trim().Equals(""))
            {
                throw new ArgumentException("Message is empty");
            }

            var output = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (Char.IsWhiteSpace(message[i]))
                {
                    output += " yo ";
                }

                else
                {
                    output = output + message[i];
                }
            }

            return output;
        }
    }
}
