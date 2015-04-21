//Author: Tobias Bladini
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperString.Test
{
    [TestClass]
    public class WhisperStringTests
    {
        private IWhisperString _whisperString = new WhisperString();

        [TestMethod]
        public void ManipulateMessageWithVowels()
        {
            //Arrange
            string value = "Hej! Detta är ett meddelande.";
            string expected = "Hij! Ditti ir itt middilindi.";

            //Act
            string actual = _whisperString.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ManipulateMessageWithoutVowels()
        {
            //Arrange
            string value = "ghfklj";
            string expected = "ghfklj";

            //Act
            string actual = _whisperString.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        //This assembly message does not comply with TeamCity.
        //Doing a work around
        //[ExpectedException(typeof(ArgumentException))]
        public void ManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";

            try
            {
                //Act
                string actual = _whisperString.ManipulateMessage(value);

                // If no exception is thrown, then the test fails.
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                // We are on!
            }
            catch
            {
                // If another exception is thrown, then the test fails.
                Assert.Fail();
            }
        }

        [TestMethod]
        //This assembly message does not comply with TeamCity.
        //Doing a work around
        //[ExpectedException(typeof(ArgumentNullException))]
        public void ManipulateMessageNullInputThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            try
            {
                //Act
                string actual = _whisperString.ManipulateMessage(value);

                // If no exception is thrown, then the test fails.
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                // We are on!
            }
            catch
            {
                // If another exception is thrown, then the test fails.
                Assert.Fail();
            }

        }

    }
}
