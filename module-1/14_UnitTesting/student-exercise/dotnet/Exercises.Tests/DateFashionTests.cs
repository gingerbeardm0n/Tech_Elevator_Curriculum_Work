using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        DateFashion testObj;

        [TestInitialize]
        public void Init()
        {
            testObj = new DateFashion();
        }
        
        [DataTestMethod]
        [DataRow(8, 2, 0)]
        [DataRow(10, 3, 2)]
        [DataRow(11, 7, 2)]
        [DataRow(-5, 50, 0)]
        public void AreYouGuysHott(int A, int B, int expectedResult)
        {
            //----Arrangle----------------------------------------

            DateFashion couple = new DateFashion();

            //----Act-----------------------------------------------
            int result = testObj.GetATable(A, B);
            //----Assert-------------------------------------------
            Assert.AreEqual(expectedResult, result);


        }
    }
}
