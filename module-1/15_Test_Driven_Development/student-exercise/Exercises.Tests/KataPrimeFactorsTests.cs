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
        public void FactorizeTest_BaseCase()
        {

            
            //----Act-----------------------------------------------

            List<int> testList = testObj.Factorize();

            //----Assert--------------------------------------------

            Assert.AreEqual(new List<int> { 1, 2 }, testList);
        }
    }
}
