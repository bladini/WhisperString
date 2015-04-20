// Author: Erik Morén
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace WhisperString.Pipeline
{
    public class SailorSongWhisperPipeline : IWhisperPipeline
    {
        private IWhisperString yo = new YoWhisperString();
        private IWhisperString koko = new WhisperStringKoko();
        private IWhisperString swap = new SwapWhisperString();
        private IWhisperString reverse = new ReverseWhisperString();
        private IWhisperString censor = new WhisperCensor();
        private IWhisperString rhyme = new RhymeWhisperString();
        private IWhisperString sn = new WhisperSecondNext();

        public string Whisper(string message)
        {
            
            string str = swap.ManipulateMessage(message);   //Start with some classic misunderstandings
            str = reverse.ManipulateMessage(str);   //..use reverse + yo + reverse to add a slightly drunken campfire feel
            str = yo.ManipulateMessage(str);
            str = reverse.ManipulateMessage(str);
            str = censor.ManipulateMessage(str);    //Mind our younger viewers with this censor pipe.
            return str;
        }
    }
}
