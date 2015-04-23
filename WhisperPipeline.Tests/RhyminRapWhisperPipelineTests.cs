using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperString.Pipeline;

namespace WhisperPipeline.Tests
{
    [TestClass]
    class RhyminRapWhisperPipelineTests
    {
        private IWhisperPipeline rhyminRapPipeline = new RhyminRapPipeline();

        [TestMethod]
        public void RhyminRapPipelineRhymes()
        {
            string value = "Viftar min flagga";
            string[] rhymingWords = { "hagga", "vagga" };
            //string[] expectedWords = { "Viftar", "yo", "min", "yo", "hagga" };
            string[] actualWords;

            actualWords = rhyminRapPipeline.Whisper(value).Split(' ');

            Assert.IsTrue(rhymingWords.Contains(actualWords.Last()));
        }

        [TestMethod]
        public void RhyminRapPipelineCreatesRap()
        {
            string value = "Viftar min flagga";
            string expected1 = "Viftar yo min yo hagga";
            string expected2 = "Viftar yo min yo vagga";
            string actual;

            actual = rhyminRapPipeline.Whisper(value);

            Assert.IsTrue(String.Equals(expected1, actual) || String.Equals(expected2, actual));
        }
    }
}
