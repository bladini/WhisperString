using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline
{
    class JohnPipeline : IWhisperPipeline
    {
        private IWhisperString rhyme = new RhymeWhisperString();
        private IWhisperString reverse = new ReverseWhisperString();
        private IWhisperString censor = new WhisperCensor();
        private IWhisperString secondNext = new WhisperSecondNext();
        private IWhisperString koko = new WhisperStringKoko();
        private IWhisperString yo = new YoWhisperString();

        public string Whisper(string message)
        {
            return rhyme.ManipulateMessage(message);
        }
    }
}
