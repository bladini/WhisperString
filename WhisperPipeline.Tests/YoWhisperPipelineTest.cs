using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperString.Pipeline;
using WhisperString;

namespace WhisperPipeline.Tests
{
    [TestClass]
    public class YoWhisperPipelineTests
    {
        private IWhisperPipeline _yoPipeline = new YoWhisperPipeline();
        [TestMethod]
        public void PipelineTestRunningRemix()
        {
            //Arrange
            string value = "hejsan lilkillen";
            string expected = "nbskei oemljkmim";

            //Act
            string actual = _yoPipeline.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}