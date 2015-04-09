using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhisperMessage
{
    public class WhisperString : IWhisperString     
    {
        public string ManipulateMessage(string message)
        {
            if (message == null)
                throw new ArgumentNullException("Message is null.");
            if (message.Trim().Equals(""))
                throw new ArgumentException("Message is empty.");
            char[] vowels = {'a', 'e', 'o', 'u', 'y','å', 'ä', 'ö',
                            'A', 'E', 'O', 'U','Y','Å', 'Ä', 'Ö'};
            foreach (var m in message)
            {
               if(vowels.Contains(m)) 
                   message = message.Replace(m, 'i');
            }
            return message;
        }
    }
}
