using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhisperMessage
{
    public class WhisperSecondNext: IWhisperString
    {

        public string ManipulateMessage(string message)
        {
            bool next = false;
            string newMessage = string.Empty;
            int inext = 0;
            if (message == null)
                throw new ArgumentNullException("Message is null.");
            if (message.Trim().Equals(""))
                throw new ArgumentException("Message is empty.");
            foreach (var letter in message)
            {
                if (Char.IsNumber(letter))
                {
                    inext = int.Parse(letter.ToString());
                    newMessage += letter.ToString();
                }
                    else if(inext>0){
                        newMessage += nextLeter(letter,inext).ToString();
                }
                    
                else if (next == false) {
                    next= true;
                    newMessage += letter.ToString();
                }
                else if (next == true) {
                    next = false;
                    newMessage += nextLeter(letter,1).ToString();
                }
            }
            return newMessage;

        }
        char nextLeter(char letter, int i) {
            char nextChar;
            if (letter == 'z')
                nextChar = 'a';
            else if (letter == 'Z')
                nextChar = 'A';

            else
                nextChar = (char)(((int)letter) + i);
            return nextChar;
        }
    }
}
