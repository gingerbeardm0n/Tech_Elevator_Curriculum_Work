using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        NonStart testObj;

        [TestInitialize]
        public void Init()
        {
            testObj = new NonStart();
        }

        [DataTestMethod]
        [DataRow("Hello", "There", "ellohere")]
        [DataRow("JayBizzle", "InTheHizzay", "ayBizzlenTheHizzay")]
        [DataRow("MattIs", "DarthVader", "attIsarthVader")]
        public void StringsOfTwoCharsOrMore(string inputA, string inputB, string expectedResult)
        {
            //----Act-----------------------------------------------
            string testArray = testObj.GetPartialString(inputA, inputB);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectedResult, testArray);
        }
        [DataTestMethod]
        [DataRow("Hi", "Bo", "io")]
        [DataRow("x", "factor", "actor")]
        [DataRow("a", "b", "")]
        public void StringsOfOneCharOrMore(string inputA, string inputB, string expectedResult)
        {
            //----Act-----------------------------------------------
            string testArray = testObj.GetPartialString(inputA, inputB);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectedResult, testArray);
        }
        [DataTestMethod]
        [DataRow("", "There", "here")]
        [DataRow("", "", "")]
        [DataRow("thisLastTestIsForFunNotSureHowElseICanBreakIt", "GotAnyIdeasMatt???????", "hisLastTestIsForFunNotSureHowElseICanBreakItotAnyIdeasMatt???????")]
        public void AtLeastOneEmptyString(string inputA, string inputB, string expectedResult)
        {
            //----Act-----------------------------------------------
            string testArray = testObj.GetPartialString(inputA, inputB);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectedResult, testArray);
        }
    }
}
