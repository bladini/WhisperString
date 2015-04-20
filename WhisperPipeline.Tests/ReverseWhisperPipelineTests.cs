//Author Lisas Module

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline.Tests
{
    [TestClass]
    public class ReverseWhisperPipelineTests
    {
        private IWhisperPipeline _reverseWhisperString = new ReverseWhisperPipeline();

        [TestMethod]
        public void PipelineTest()
        {
            //Arrange
            string value = "Hej och hå";
            string expected = "jeh hco åh";

            //Act
            string actual = _reverseWhisperString.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
