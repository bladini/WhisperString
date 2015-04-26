/// Author: Gabriel

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline {
    public class CaesarCipherWhisperPipeline : IWhisperPipeline {

        public string Whisper(string message) {
            return new IWhisperString[] { 
                           new YoWhisperString(), 
                           new WhisperStringKoko(),
                           new SwapWhisperString(),
                           new ReverseWhisperString(),
                           new WhisperCensor(), 
                           new RhymeWhisperString(), 
                           new WhisperSecondNext(),
                           new CaesarCipherWhisperString() }
                           .Aggregate(message, (a, b) => b.ManipulateMessage(a));
        }
    }
}
