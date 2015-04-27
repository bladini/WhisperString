// Auther : Noman Elahi
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperString.Pipeline;

namespace WhisperPipeline.Tests
{
    [TestClass]
    public class CrazyEncryptionPipelineTest
    {
        private IWhisperPipeline KoKoPipeline = new KokoWhisperPipeline();

        [TestMethod]
        public void MixedFiltersPipeline()
        {
            //Arrange
            string value = "Hello pappa how are you";
            string expected = "olleh yo appak yo woh yo era yo uoy";

            //Act
            string actual = KoKoPipeline.Whisper(value);
                
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
