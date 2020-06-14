using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        SameFirstLast testObj;

        [TestInitialize]
        public void Init()
        {
            testObj = new SameFirstLast();
        }

        [DataTestMethod]
        [DataRow(new int[] { 8, 5, 8 }, true)]
        [DataRow(new int[] { 1, 5, 5 }, false)]
        [DataRow(new int[] { 10, 5, 67, 5123, 10 }, true)]
        public void PositiveNumbersAtLeastLength3(int[] input, bool expectedResult)
        {   
            //----Act-----------------------------------------------
            bool result = testObj.IsItTheSame(input);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectedResult, result);
        }
        [DataTestMethod]
        [DataRow(new int[] { 8}, true)]
        [DataRow(new int[] { 2, 2}, true)]
        [DataRow(new int[] { 500, 6, 500 }, true)]
        public void PositiveNumbersAtLeastLength1(int[] input, bool expectedResult)
        {
            //----Act-----------------------------------------------
            bool result = testObj.IsItTheSame(input);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectedResult, result);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, false)]
        [DataRow(new int[] { -1, 5, -1 }, true)]
        [DataRow(new int[] { -12, -58, 0, 45, -12}, true)]
        public void SomeNegativeSomeZeroSomeEmpty(int[] input, bool expectedResult)
        {
            //----Act-----------------------------------------------
            bool result = testObj.IsItTheSame(input);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectedResult, result);
        }
    }
}
