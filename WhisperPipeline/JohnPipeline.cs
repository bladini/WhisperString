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

        public string Whisper(string message)
        {
            return rhyme.ManipulateMessage(message);
        }
    }
}
