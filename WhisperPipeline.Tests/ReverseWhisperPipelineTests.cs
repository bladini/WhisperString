﻿//Author Lisas Module

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline.Tests
{
    [TestClass]
    public class CharToWordWhisperPipelineTests
    {
        private IWhisperPipeline _chartowordWhisperString = new ReverseWhisperPipeline();

        [TestMethod]
        public void PipelineTest()
        {
            //Arrange
            string value = "Hej och hå";
            string expected = "jeh hco åh";

            //Act
            string actual = _chartowordWhisperString.Whisper(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
