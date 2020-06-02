using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        StringBits testObj;

        [TestInitialize]
        public void Init()
        {
            testObj = new StringBits();
        }

        [DataTestMethod]
        [DataRow("Hello", "Hlo")]
        [DataRow("JayBizzle",  "Jyize")]
        [DataRow("MattIs", "MtI")]
        public void StringFiveOrMorChars(string input, string expectedResult)
        {
            //----Act-----------------------------------------------
            string result = testObj.GetBits(input);
            //----Assert------------------------------------------- 
            Assert.AreEqual(expectedResult, result);
        }
        [DataTestMethod]
        [DataRow("Bo", "B")]
        [DataRow("JaJa", "JJ")]
        [DataRow("xY", "x")]
        public void StringTwoOrMorChars(string input, string expectedResult)
        {
            //----Act-----------------------------------------------
            string result = testObj.GetBits(input);
            //----Assert------------------------------------------- 
            Assert.AreEqual(expectedResult, result);
        }
        [DataTestMethod]
        [DataRow("", "")]
        [DataRow(null, "")]
        public void EmptyStringNullString (string input, string expectedResult)
        {
            //----Act-----------------------------------------------
            string result = testObj.GetBits(input);
            //----Assert------------------------------------------- 
            Assert.AreEqual(expectedResult, result);
        }

    }
}
