//Author Sing
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhisperString.Test
{
    [TestClass]
    public class WhisperCensorTest
    {
        private IWhisperString _whisperCensor = new WhisperCensor();

        [TestMethod]
        public void ManipulateMessageWithCensor()
        {
            //Arrange
            string value = "fuck, hello";
            string expected = "****, hello";

            //Act
            string actual = _whisperCensor.ManipulateMessage(value);


            //Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void ManipulateMessageWithEmptystringCensor()
        {
            string value = "";

            try {
            string actual = _whisperCensor.ManipulateMessage(value);

            
                //If no exception is thrown, then it fails.
                Assert.Fail("Exppected ArgumentException");
            }
            catch (ArgumentException)
            {
                
                //This is what should happen. No fail.
            }

            catch
            {
                //If another expetion is thrown, then it fails
                Assert.Fail("Exppected ArgumentException");

            }



        }

        [TestMethod]
        public void ManipulateMessageWithNullCensor()
        {
            string value = null;

            try {
            string actual = _whisperCensor.ManipulateMessage(value);

            
                //If no exception is thrown, then it fails.
                Assert.Fail("Exppected ArgumentNullException");
            }
            catch (ArgumentNullException)
            {
                
                //This is what should happen. No fail.
            }

            catch
            {
                //If another expetion is thrown, then it fails
                Assert.Fail("Exppected ArgumentNullException");

            }
        }
    }
}
