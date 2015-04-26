// Author: Stanislav Hallberg
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline
{
   public class NotRandomPipeline : IWhisperPipeline
    {
        private IWhisperString  _SecondNext = new WhisperSecondNext();
        private IWhisperString _Koko = new WhisperStringKoko();
        private IWhisperString _yo = new YoWhisperString();
        private IWhisperString _Reverse = new ReverseWhisperString();
        private IWhisperString _caesarCipher = new CaesarCipherWhisperString();
        private IWhisperString _rhyme = new RhymeWhisperString();
        private IWhisperString _swap = new SwapWhisperString();
        private IWhisperString _censor = new WhisperCensor();
        private IWhisperString _charToWord = new CharToWordWhisperString();
        public string Whisper(string message)
        {
            message = _SecondNext.ManipulateMessage(message);
            message = _Koko.ManipulateMessage(message);
            message = _yo.ManipulateMessage(message);
            message = _Reverse.ManipulateMessage(message);
            message = _caesarCipher.ManipulateMessage(message);
            message = _rhyme.ManipulateMessage(message);
            message = _swap.ManipulateMessage(message);
            message = _censor.ManipulateMessage(message);
            message = _charToWord.ManipulateMessage(message);

            return message;
        }

    }
}
