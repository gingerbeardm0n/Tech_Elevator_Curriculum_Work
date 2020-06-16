using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    
    [TestClass]
    public class KataPrimeFactorsTests
    {
        [TestMethod]
        public void Factorize()
        {

        //----Arrange-------------------------------------------

        KataPrimeFactors testObj = new KataPrimeFactors();

        //----Act-----------------------------------------------

        List<int> testList = testObj.Factorize(25);

        //----Assert--------------------------------------------
        }
    }
}
