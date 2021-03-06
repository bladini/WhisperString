﻿//Author Daniel module

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline
{
    public class CharToWordWhisperPipeline : IWhisperPipeline
    {
        private IWhisperString john = new RhymeWhisperString();
        private IWhisperString censor = new WhisperCensor();
        private IWhisperString erik = new SwapWhisperString();
        private IWhisperString reverse = new ReverseWhisperString();

        public string Whisper(string message)
        {
            string str = john.ManipulateMessage(message);
            str = censor.ManipulateMessage(str);
            str = erik.ManipulateMessage(str);
            str = reverse.ManipulateMessage(str);
            
            return str;
        }
    }
}
