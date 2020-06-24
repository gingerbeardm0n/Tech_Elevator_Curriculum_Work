using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPrimeFactorsTests
    {
        KataPrimeFactors testObj;

        [TestInitialize]
        public void Init()
        {
            testObj = new KataPrimeFactors();
        }

        [TestMethod]
        public void FactorizeTest_two()
        {

            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(2);
            //----Assert--------------------------------------------
            Assert.AreEqual(2, testList[0]);

        }
        [TestMethod]
        public void FactorizeTest_three()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(3);
            //----Assert--------------------------------------------
            Assert.AreEqual(3, testList[0]);
        }
        [TestMethod]
        public void FactorizeTest_four()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(4);
            //----Assert--------------------------------------------
            Assert.AreEqual(2, testList[0]);
            Assert.AreEqual(2, testList[1]);
        }
        [TestMethod]
        public void FactorizeTest_six()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(6);
            //----Assert--------------------------------------------
            Assert.AreEqual(2, testList[0]);
            Assert.AreEqual(3, testList[1]);
        }
        [TestMethod]
        public void FactorizeTest_seven()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(7);
            //----Assert--------------------------------------------
            Assert.AreEqual(7, testList[0]);
            
        }
        [TestMethod]
        public void FactorizeTest_eight()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(8);
            //----Assert--------------------------------------------
            Assert.AreEqual(2, testList[0]);
            Assert.AreEqual(2, testList[1]);
            Assert.AreEqual(2, testList[2]);
        }
        [TestMethod]
        public void FactorizeTest_nine()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(9);
            //----Assert--------------------------------------------
            Assert.AreEqual(3, testList[0]);
            Assert.AreEqual(3, testList[1]);
        }






    }
    
}
