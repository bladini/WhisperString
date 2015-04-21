//Author Daniels module

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperString.Test
{
    [TestClass]
    public class CharToWordWhisperStringTests
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



        //Exceptions
        [TestMethod]
        public void CharToWordMessageArgumentException()
        {
            string value = "";

            try
            {
                string actual = _chartowordMessage.ManipulateMessage(value);

                //No exception at all thrown. Fail!
                Assert.Fail("Expected ArgumentException");
            }
            catch (ArgumentException)
            {
                //ArgumentException thrown. This is good!
            }
            catch (Exception)
            {
                //Wrong exception thrown. Fail!
                Assert.Fail("Expected ArgumentException");
            }
        }


        [TestMethod]
        public void CharToWordMessageArgumentNullException()
        {
            string value = null;

            try
            {
                string actual = _chartowordMessage.ManipulateMessage(value);

                //No exception at all thrown.
                Assert.Fail("Expected ArgumentNullException");
            }
            catch (ArgumentNullException)
            {
                //ArgumentException thrown. 
            }
            catch (Exception)
            {
                //Wrong exception thrown, fail
                Assert.Fail("Expected ArgumentNullException");
            }


        }
        //end exceptions








    }
}
