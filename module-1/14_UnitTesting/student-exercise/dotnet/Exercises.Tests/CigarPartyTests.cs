using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]
        public void IsThePartyAHit()
        {
            //----Arrangle----------------------------------------

            CigarParty party = new CigarParty();

            //----Act-----------------------------------------------

            bool isABanger1 = party.HaveParty(100, true);
            bool isABanger2 = party.HaveParty(30, true);
            bool isABanger3 = party.HaveParty(70, false);
            bool isABanger4 = party.HaveParty(40, false);

            //----Assert-------------------------------------------

            Assert.AreEqual(true, isABanger1);
            Assert.AreEqual(false, isABanger2);
            Assert.AreEqual(false, isABanger3);
            Assert.AreEqual(true, isABanger4);


        }




    }
}
