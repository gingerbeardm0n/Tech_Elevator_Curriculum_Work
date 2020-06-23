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

            List<int> testList1 = testObj.Factorize(2);

            //----Assert--------------------------------------------

            Assert.ReferenceEquals(new List<int> { 2 }, testList1);
        }
    }
}
