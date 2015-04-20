using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperString.Test
{
    [TestClass]
    public class YoWhisperStringTests
    {
        private IWhisperString _yoWhisperString = new YoWhisperString();
        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void YoManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";
            try
            {
                string actual = _yoWhisperString.ManipulateMessage(value);

                Assert.Fail("Expected ArgumentException");
            }
            catch (ArgumentException)
            {
                
            }
            catch
            {
                Assert.Fail("Expected ArgumentException");
            }

            //Act
            
        }
        [TestMethod] 
        //[ExpectedException(typeof(ArgumentNullException))]
        public void YoManipulateMessageNullThrowArgumentNullException()
        {
            //Arrange
            string value = null;
            try
            {
                string actual = _yoWhisperString.ManipulateMessage(value);

                Assert.Fail("Expected ArgumentNullException");
            }
            catch (ArgumentNullException)
            {
                 
            } 
            catch
            {
                Assert.Fail("Expected ArgumentNullException");
            }
            //Act
            
        }
        [TestMethod]
        public void YoManipulateMessageEveryWhiteSpaceWithYou()
        {
            //Arrange
            string value = "Hur mår du da ";
            string expected = "Hur yo mår yo du yo da yo ";

            //Act
            string actual = _yoWhisperString.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
