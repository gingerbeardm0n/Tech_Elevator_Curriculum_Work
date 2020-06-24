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
        public void FactorizeTest_2()
        {

            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(2);
            //----Assert--------------------------------------------
            Assert.AreEqual(2, testList[0]);

        }
        [TestMethod]
        public void FactorizeTest_3()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(3);
            //----Assert--------------------------------------------
            Assert.AreEqual(3, testList[0]);
        }
        [TestMethod]
        public void FactorizeTest_4()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(4);
            //----Assert--------------------------------------------
            Assert.AreEqual(2, testList[0]);
            Assert.AreEqual(2, testList[1]);
        }
        [TestMethod]
        public void FactorizeTest_6()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(6);
            //----Assert--------------------------------------------
            Assert.AreEqual(2, testList[0]);
            Assert.AreEqual(3, testList[1]);
        }
        [TestMethod]
        public void FactorizeTest_7()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(7);
            //----Assert--------------------------------------------
            Assert.AreEqual(7, testList[0]);
            
        }
        [TestMethod]
        public void FactorizeTest_8()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(8);
            //----Assert--------------------------------------------
            Assert.AreEqual(2, testList[0]);
            Assert.AreEqual(2, testList[1]);
            Assert.AreEqual(2, testList[2]);
        }
        [TestMethod]
        public void FactorizeTest_9()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(9);
            //----Assert--------------------------------------------
            Assert.AreEqual(3, testList[0]);
            Assert.AreEqual(3, testList[1]);
        }
        [TestMethod]
        public void FactorizeTest_10()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(10);
            //----Assert--------------------------------------------
            Assert.AreEqual(2, testList[0]);
            Assert.AreEqual(5, testList[1]);
        }
        [TestMethod]
        public void FactorizeTest_30()
        {
            //----Act-----------------------------------------------
            List<int> testList = testObj.Factorize(30);
            //----Assert--------------------------------------------
            Assert.AreEqual(2, testList[0]);
            Assert.AreEqual(3, testList[1]);
            Assert.AreEqual(5, testList[2]);
        }






    }
    
}
