using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperString.Test
{
    [TestClass]
    public class SwapWhisperStringTests
    {
        private IWhisperString _swapWhisperString = new SwapWhisperString();
        
        /*
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void SwapManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";

            //Act
            string actual = _swapWhisperString.ManipulateMessage(value);
        }*/
        
        [TestMethod]
        public void SwapManipulateMessageEmptyStringThrowArgumentException()
        {
            //Arrange
            string value = "";

            try
            {
                string actual = _swapWhisperString.ManipulateMessage(value);

                //No exception at all thrown. Fail!
                Assert.Fail();
            } 
            catch(ArgumentException)
            {
                //ArgumentException thrown. This is good!
            }
            catch(Exception)
            {
                //Wrong exception thrown. Fail!
                Assert.Fail();
            }
        }

        /*
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void SwapManipulateMessageNullThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            string actual = _swapWhisperString.ManipulateMessage(value);
        }
        */

        [TestMethod]
        public void SwapManipulateMessageNullThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            try
            {
                string actual = _swapWhisperString.ManipulateMessage(value);

                //No exception at all thrown. Fail!
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                //ArgumentNullException thrown. This is good!
                
            }
            catch (Exception)
            {
                //Wrong exception thrown. Fail!
                Assert.Fail();
            }

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
