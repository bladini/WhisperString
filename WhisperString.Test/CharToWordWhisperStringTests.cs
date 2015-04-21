//Author Daniels module

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperString.Test
{
    [TestClass]
    public class CharToWordWhisperStringTest
    {
        IWhisperString _chartowordMessage = new CharToWordWhisperString();
        [TestMethod]
        public void CharToWordWhisperMessageTest()
        {
            //Arrange
            string value = "a";
            string expected = "apa";

            //Act
            string actual = _chartowordMessage.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
