using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDLabTwo.Test
{
    [TestClass]
    public class TDDLabEx
    {

        private TestFinder _TestFinder = null;

        [TestInitialize]
        public void InitTest()
        {
            _TestFinder = new TestFinder();
        }

        [TestMethod]
        public void CheckLenght()
        {
            //Arrange
            string value = "hej";
            int expected = 3;

            //Act

            int actual = _TestFinder.CountStringLenght(value);

            //Assert
            Assert.AreEqual(expected, actual);


        }
    }
}
