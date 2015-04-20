//Author Sing
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperString.Pipeline;

namespace WhisperPipeline.Tests
{
    [TestClass]
    public class CensorWhisperStringPipelineTests
    {
        private IWhisperPipeline _censorPipeline = new CensorPipeline();

        [TestMethod]
        public void mergePipelines()
        {
            //Arrange
            string value = "Hej jag gillar kaka";
            string expected = "Jeh oy gaj oy rallig oy aokokaokok";


            //Act
            string actual = _censorPipeline.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
