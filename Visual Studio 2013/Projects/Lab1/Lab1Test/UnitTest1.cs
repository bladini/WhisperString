using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace Lab1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnConcatenatedString()
        {
            //Arrange
            string[] arr = new string[] { "Hej", "då"};
            string expected = "Hej då";
            string actual;
            
            //Act
            

            actual = StringExtension.ConcatArrayWithSpace(arr);

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void ReturnCapitalize()
        {
            //Arrange
            string word = "vad vill du";
            
            string expected = "VADVILLDU";
            string actual;

            //Act
            actual = StringExtension.Capitalize(word);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnUpperCaseFirstEach()
        {
            //Arrange
            string bla = "hejsdfs hej";
            string expected = "Hejsdfs Hej";
            string actual;
                        

            //Act
            actual = StringExtension.UpperCaseFirstEach(bla);

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void ReturnAverage()
        {
            //Arrange
            int y = 10;
            int x = 2;
            int expected = 6;
            int actual;

            //Act
            actual = StringExtension.Average(x, y);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
