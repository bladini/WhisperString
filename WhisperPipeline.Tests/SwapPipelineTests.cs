using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperString.Pipeline;

namespace WhisperPipeline.Test
{
    [TestClass]
    public class SwapPipelineTests
    {
        private IWhisperPipeline _swapPipeline = new SwapPipeline();

        [TestMethod]
        public void SwapPipelineTest()
        {
            //Arrange
            string value = "Hej och hå";
            string expected = "Jeh  oy  hokoko  oy  åh";


            //Act
            string actual = _swapPipeline.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

