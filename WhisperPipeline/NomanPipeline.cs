using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline
{
    class NomanPipeline
    {
        public class NomanPipeline : IWhisperPipeline
        {
            private IWhisperString whisperYo = new YoWhisperString();
            private IWhisperString whisperReverse = new ReverseWhisperMessage();
            private IWhisperString whisperSecondNext = new WhisperSecondNext();


            public string Whisper(string message)
            {
                message = whisperYo.ManipulateMessage(message);
                message = whisperReverse.ManipulateMessage(message);
                message = whisperSecondNext.ManipulateMessage(message);

                return message;

            }

        }
    }
}