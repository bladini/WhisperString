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

        public string Whisper(string message)
        {
            return rhyme.ManipulateMessage(message);
        }
    }
}
