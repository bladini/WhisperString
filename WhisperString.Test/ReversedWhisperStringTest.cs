//Author Lisas module

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperString.Test
{
    [TestClass]
    public class ReversedWhisperStringTest
    {
        IWhisperString _reverseMessage = new ReverseWhisperString();
        [TestMethod]
        public void ReverseWhisperMessageTest()
        {
            //Arrange
            string value = "Hej på dig";
            string expected = "Jeh åp gid";

            //Act
            string actual = _reverseMessage.ManipulateMessage(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void ReversedMessageArgumentException()
        {
            string value = "";

            try
            {
                string actual = _reverseMessage.ManipulateMessage(value);

                //No exception at all thrown. Fail!
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                //ArgumentException thrown. This is good!
            }
            catch (Exception)
            {
                //Wrong exception thrown. Fail!
                Assert.Fail();
            }
        }

        [TestMethod] 
        //[ExpectedException(typeof(ArgumentNullException))]
        public void ReversedMessageArgumentNullException()
        {
            string value = null;

            try
            {
                string actual = _reverseMessage.ManipulateMessage(value);

                //No exception at all thrown. Fail!
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                //ArgumentException thrown. This is good!
            }
            catch (Exception)
            {
                //Wrong exception thrown. Fail!
                Assert.Fail();
            }


        }
    }
}
