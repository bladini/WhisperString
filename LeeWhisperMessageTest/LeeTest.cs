using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperMessage.Pipeline;

namespace WhisperMessage.Test
{
    [TestClass]
    public class LeeTest
    {

        private IWhisperPipeline _whisperString = new WhisperCreateCalculation();

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CalcManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";

            //Act
            string actual = _whisperString.Whisper(value);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void CalcManipulateMessageNullInputThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            string actual = _whisperString.Whisper(value);
        }

        [TestMethod]
        public void CalcManipulateMessageTestSentence()
        {

            //Arrange
            string value = "Why hello there how are you today?";
            string expected = "Why + hello - there * how / are + you = today?";

            //Act
            string actual = _whisperString.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CalcManipulateMessageTestOneWord()
        {

            //Arrange
            string value = "Hello";
            string expected = "Hello";

            //Act
            string actual = _whisperString.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
