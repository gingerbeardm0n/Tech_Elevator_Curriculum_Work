using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        [TestMethod]
        public void AreYouGuysHott()
        {
            //----Arrangle----------------------------------------

            DateFashion couple = new DateFashion();

            //----Act-----------------------------------------------

            int hottTest1 = couple.GetATable(8, 2);
            int hottTest2 = couple.GetATable(10, 3);
            int hottTest3 = couple.GetATable(11, 7);
            int hottTest4 = couple.GetATable(-5, 50);

            //----Assert-------------------------------------------

            Assert.AreEqual(0, hottTest1);
            Assert.AreEqual(2, hottTest2);
            Assert.AreEqual(1, hottTest3);
            Assert.AreEqual(1, hottTest4);



        }
    }
}
