//Auther : Noman Elahi
using System.Threading.Tasks;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline
{
   
        public class KokoWhisperPipeline : IWhisperPipeline
        {
            private IWhisperString whisperYo = new YoWhisperString();
            private IWhisperString whisperReverse = new ReverseWhisperString();
           // private IWhisperString whisperRhyme = new RhymeWhisperString();


            public string Whisper(string message)
            {
                message = whisperYo.ManipulateMessage(message);
              message = whisperReverse.ManipulateMessage(message);
            //    message = whisperRhyme.ManipulateMessage(message);

                return message;

            }

        }
    
}
