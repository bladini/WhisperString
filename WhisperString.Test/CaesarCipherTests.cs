/// Author: Gabriel

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhisperString;

namespace WhisperString.Test {
    [TestClass]
    public class CaesarCipherTests {
        
        // Commenting out the test since the module itself is missing

        private IWhisperString _caesarCipher = new CaesarCipherWhisperString();

        [TestMethod]
        public void ManipulateMessage() {
            string value = "abc";
            string expected = "def";

            string actual = _caesarCipher.ManipulateMessage(value);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ManipulateMixedMessage() {
            string value = "abc9!!!";
            string expected = "def9!!!";

            string actual = _caesarCipher.ManipulateMessage(value);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ManipulateMessageEmptyStringReturnEmpty() {
            string value = "";
            var expected = "";

            Assert.AreEqual(_caesarCipher.ManipulateMessage(value), expected);
        }

        [TestMethod]
        public void ManipulateMessageNullInputReturnNull() {
            string value = null;
            string expected = null;

            Assert.AreEqual(_caesarCipher.ManipulateMessage(value), expected);
        }
         
    }
}
