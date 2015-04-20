using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDLabTwoPart2CLib;

namespace TDDLabTwoPart2Test
{
    [TestClass]
    public class Test2
    {
        private TypeFinder _typeFinder = null;

        [TestInitialize]
        public void InitTest()
        {
            _typeFinder = new TypeFinder();
        }

        [TestMethod]
        public void CheckStringTypeNumber()
        {

            //Arrange
            string value = "1";
            string expected = "Number";
            string actual;

            //Act
            actual = _typeFinder.StringTypeFinder(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckStringTypeWord()
        {

            //Arrange
            string value = "hej";
            string expected = "Word";
            string actual;

            //Act
            actual = _typeFinder.StringTypeFinder(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

       
    }
}
