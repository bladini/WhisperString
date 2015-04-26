using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline
{
    public class RhyminRapPipeline : IWhisperPipeline
    {
        private IWhisperString rhyme = new RhymeWhisperString();
        private IWhisperString censor = new WhisperCensor();
        private IWhisperString yo = new YoWhisperString();

        public string Whisper(string message)
        {
            message = rhyme.ManipulateMessage(message);
            message = censor.ManipulateMessage(message);
            message = yo.ManipulateMessage(message);
            return message;
        }
    }
}
