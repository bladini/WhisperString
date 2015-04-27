//Auther : Noman Elahi
using System.Threading.Tasks;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline
{
   
        public class KoKoWhisperPipeline : IWhisperPipeline
        {
            private IWhisperString whisperYo = new YoWhisperString();
            private IWhisperString whisperReverse = new ReverseWhisperString();
            private IWhisperString whisperSecondNext = new WhisperSecondNext();


            public string Whisper(string message)
            {
                message = whisperYo.ManipulateMessage(message);
              //  message = whisperReverse.ManipulateMessage(message);
                message = whisperSecondNext.ManipulateMessage(message);

                return message;

            }

        }
    
}
