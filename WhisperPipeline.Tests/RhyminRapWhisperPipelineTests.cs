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
    public class RhyminRapWhisperPipelineTests
    {
        private IWhisperPipeline rhyminRapPipeline = new RhyminRapPipeline();

        [TestMethod]
        public void RhyminRapPipelineRhymes()
        {
            string value = "Viftar min flagga";
            string[] rhymingWords = { "hagga", "vagga" };
            string[] actualWords;

            actualWords = rhyminRapPipeline.Whisper(value).Split(' ');

            Assert.IsTrue(rhymingWords.Contains(actualWords.Last()));
        }

        [TestMethod]
        public void RhyminRapPipelineCreatesRap()
        {
            string value = "Viftar min flagga";
            string[] expectedWords = ("Viftar yo min yo hagga").Split(' ');
            string[] actualWords;

            actualWords = rhyminRapPipeline.Whisper(value).Split(' ');

            Assert.IsTrue(expectedWords[1] == actualWords[1] && expectedWords[3] == actualWords[3]);
        }
    }
}
