using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        Lucky13 testObj;

        [TestInitialize]
        public void Init()
        {
            testObj = new Lucky13();
        }

        [DataTestMethod]
        [DataRow(new int[] { 4, 5, 6 }, true)]
        [DataRow(new int[] { 0, 5, 12, 6 }, true)]
        [DataRow(new int[] { 2, 5, 11, -5, -58, 13, 33 }, true)]
        public void ContainsNoOnesOrThrees(int[] input, bool expectededResult)
        {
            //----Act-----------------------------------------------
            bool isItTrue = testObj.GetLucky(input);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectededResult, isItTrue);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1 }, false)]
        [DataRow(new int[] { 0, -5, 1 }, false)]
        [DataRow(new int[] { 2,0,6,45,15,6,48,158 }, true)]
        [DataRow(new int[] { }, true)]
        public void ContainsAOne(int[] input, bool expectededResult)
        {
            //----Act-----------------------------------------------
            bool isItTrue = testObj.GetLucky(input);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectededResult, isItTrue);
        }

        [DataTestMethod]
        [DataRow(new int[] { 3, 5, 6 }, false)]
        [DataRow(new int[] { 0, 3, 12, 6 }, false)]
        [DataRow(new int[] { 3 }, false)]
        public void ContainsAThree(int[] input, bool expectededResult)
        {
            //----Act-----------------------------------------------
            bool isItTrue = testObj.GetLucky(input);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectededResult, isItTrue);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 3, 6 }, false)]
        [DataRow(new int[] { 13, 0}, true)]
        [DataRow(new int[] { 2, 5, 1, -5, -58, 13, 3 }, false)]
        public void ContainsBothOnesAndThrees(int[] input, bool expectededResult)
        {
            //----Act-----------------------------------------------
            bool isItTrue = testObj.GetLucky(input);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectededResult, isItTrue);
        }
    }
}
