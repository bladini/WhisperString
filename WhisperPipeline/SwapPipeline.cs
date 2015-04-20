// Author: Erik
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace WhisperString.Pipeline
{
    public class SwapPipeline : IWhisperPipeline
    {
        private IWhisperString yo = new YoWhisperString();
        private IWhisperString koko = new WhisperStringKoko();
        private IWhisperString swap = new SwapWhisperString();
        private IWhisperString reverse = new ReverseWhisperString();

        public string Whisper(string message)
        {
            string str = yo.ManipulateMessage(message);
            str = koko.ManipulateMessage(str);
            str = swap.ManipulateMessage(str);
            str = reverse.ManipulateMessage(str);

            return str;
        }
    }
}
