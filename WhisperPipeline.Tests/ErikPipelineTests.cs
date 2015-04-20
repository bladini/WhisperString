using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperPipeline;

namespace WhisperPipeline.Test
{
    [TestClass]
    public class ErikPipelineTests
    {
        private IWhisperPipeline _swapPipeline = new SwapPipeline();

        [TestMethod]
        public void SwapPipelineTest()
        {
            //Arrange
            string value = "Hej och hå";
            string expected = "Jeh  oy  hokoko  oy  åh";


            //Act
            string actual = _erikPipeline.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

