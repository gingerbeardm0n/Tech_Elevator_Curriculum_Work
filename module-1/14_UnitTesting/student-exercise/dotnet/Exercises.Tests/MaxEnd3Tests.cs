using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        MaxEnd3 testObj;

        [TestInitialize]
        public void Init()
        {
            testObj = new MaxEnd3();
        }

        [DataTestMethod]
        [DataRow(new int[] { 8, 5, 4 }, new int[] { 8, 8, 8 })]
        [DataRow(new int[] { 1, 5, -5 }, new int[] { 1, 1, 1 })]
        [DataRow(new int[] { 0, -5, -10 }, new int[] { 0, 0, 0 })]
        public void FirstNumberIsLarger(int[] input, int[] expectedResult)
        {
            //----Act-----------------------------------------------
            int[] testArray = testObj.MakeArray(input);
            //----Assert--------------------------------------------
            Assert.ReferenceEquals(expectedResult, testArray);
        }

        //
        //
        [DataTestMethod]
        [DataRow(new int[] { 0, 5, 4 }, new int[] { 4, 4, 4 })]
        [DataRow(new int[] { 2, 60, -5, 9 }, new int[] { 9, 9, 9, 9})]
        [DataRow(new int[] { -5, 0, -2 }, new int[] { -2, -2, -2 })]
        public void LastNumberIsLarger(int[] input, int[] expectedResult)
        {
            //----Act-----------------------------------------------
            int[] testArray = testObj.MakeArray(input);
            //----Assert--------------------------------------------
            Assert.ReferenceEquals(expectedResult, testArray);
        }

        [DataTestMethod]
        [DataRow(new int[] { 8, 5, 8 }, new int[] { 8, 8, 8 })]
        [DataRow(new int[] { 1, 15, 1 }, new int[] { 1, 1, 1 })]
        [DataRow(new int[] { 0, -42, 0 }, new int[] { 0, 0, 0 })]
        public void FirstAndLastTheSame(int[] nums, int[] expectedResult)
        {
            //----Act-----------------------------------------------
            int[] testArray = testObj.MakeArray(nums);
            //----Assert--------------------------------------------
            Assert.ReferenceEquals(expectedResult, testArray);
        }








    }
}
