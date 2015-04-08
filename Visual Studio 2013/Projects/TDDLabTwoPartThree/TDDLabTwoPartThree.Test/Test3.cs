using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDLabTwoPartThree.Test
{
    [TestClass]
    public class Test3
    {
        private NextPalidromeFinder _nextPalindromeFinder = null;

        [TestInitialize]
        public void InitTest()
        {
            _nextPalindromeFinder = new NextPalidromeFinder();
        }

        [TestMethod]
        public void NextPalindromeNumberIs()
        {

            //Arrange
            int value = 121;
            int expected = 131;
            int actual;

            //Act
            actual = _nextPalindromeFinder.NextPalindrome(value);


            //Assert
            Assert.AreEqual(expected, actual);



        }


        [TestMethod]
        public void NextPalindromeNumberIsToHigh()
        {

            //Arrange
            string value = "1000";
            bool expected = false;
            bool actual;

            //Act
            actual = _nextPalindromeFinder.NumberPalindrome(value);


            //Assert
            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void NextPalindromeNumberIsToLow()
        {

            //Arrange
            string value = "11";
            bool expected = false;
            bool actual;

            //Act
            actual = _nextPalindromeFinder.NumberPalindrome(value);


            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void isPalindromeNumber()
        {

            //Arrange
            string value = "121";
            bool expected = true;
            bool actual;

            //Act
            actual = _nextPalindromeFinder.NumberPalindrome(value);


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
