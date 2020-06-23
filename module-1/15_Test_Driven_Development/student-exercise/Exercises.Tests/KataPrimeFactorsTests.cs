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
            List<int> testList = testObj.Factorize(3);
            //----Assert--------------------------------------------
            Assert.AreEqual(4, testList[0]);
        }





    }
}
