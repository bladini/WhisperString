using RhymeWhisperMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperMessage;
using WhisperMessage.Pipeline;

namespace WhisperPipeline
{
    class JohnPipeline : IWhisperPipeline
    {
        private IWhisperString rhyme = new RhymeWhisper();
        private IWhisperString yo = new YoWhisperString();
        private IWhisperString koko = new WhisperStringKoko();
        private IWhisperString erik = new ErikWhisperString();
        private IWhisperString lee = new WhisperCreateCalculation();
        private IWhisperString reverse = new ReverseWhisperMessage();

        public string Whisper(string message)
        {
            return rhyme.ManipulateMessage(message);
        }
    }
}
