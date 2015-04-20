using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperString.Test
{
    [TestClass]
    public class SwapWhisperStringTests
    {
        private IWhisperString _swapWhisperString = new SwapWhisperString();
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void SwapManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";

            //Act
            string actual = _swapWhisperString.ManipulateMessage(value);
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void SwapManipulateMessageNullThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            string actual = _swapWhisperString.ManipulateMessage(value);
        }
        [TestMethod]
        public void SwapManipulateMessage()
        {
            //Arrange
            string value = "jag är glad";
            string expected = "stag bär glad";

            //Act
            string actual = _swapWhisperString.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
