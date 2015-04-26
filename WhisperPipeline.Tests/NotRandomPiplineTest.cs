using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperString;
using WhisperString.Pipeline;

namespace WhisperPipeline.Tests
{
    [TestClass]
    public class NotRandomPiplineTest
    {
        IWhisperPipeline test = new NotRandomPipeline();
      
        [TestMethod]
        public void NotRandomTest()
        {
            string value = "Test";
            string expected = "cykelviiw";
            string acteul = test.Whisper(value);
            Assert.AreEqual(expected, acteul);

        }
    }
}
