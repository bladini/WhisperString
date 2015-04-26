///Author: Gabriel
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperString.Pipeline;

namespace WhisperPipeline.Tests {
    [TestClass]
    public class CaesarCipherWhisperPipelineTests {

        [TestMethod]
        public void CaesarCipherPipelineTest() {
            var value = "abc";
            var expected = "roroee";
            var pipe = new CaesarCipherWhisperPipeline();

            var actual = pipe.Whisper(value);
            Assert.AreEqual(expected, actual);
        }
        
    }
}
