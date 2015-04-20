using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;

namespace MathLibraryTest
{
    [TestClass]
    public class IntegerExtensionsTest
    {
        private TestContext testContextInstance;

        [TestMethod]
        public void FactorialOfNegativeNumberReturnsMinusOne()
        {
            //Arrange
            int num = -5;
            int expected = -1;
            int actual;

            //Act
            actual = IntegerExtensions.Factorial(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FactorialOfZeroReturnsOneTest()
        {
            //Arrange
            int num = 0;
            int expected = 1;
            int actual;

            //Act
            actual = IntegerExtensions.Factorial(num);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FactorialOfPositiveNumberTestReturnsFactorial()
        {
            //Arrange
            int num = 3;
            int expected = 6;
            int actual;

            //Act
            actual = IntegerExtensions.Factorial(num);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
