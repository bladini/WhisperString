// Author: Erik Morén
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperString.Pipeline;

namespace WhisperPipeline.Test
{
    [TestClass]
    public class SailorSongWhisperPipelineTests
    {
        private IWhisperPipeline _sailorPipeline = new SailorSongWhisperPipeline();

        [TestMethod]
        public void SailorSongPipelineTest()
        {
            //Arrange
            string value = "Hej och hå och en flaska med rom";
            string expected = "Hej oy och oy hå oy och oy en oy flaska oy med oy rom";


            //Act
            string actual = _sailorPipeline.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
