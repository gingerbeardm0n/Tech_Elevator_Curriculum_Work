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
        public void IsThePartyAHit_BaseCases()
        {
            //----Arrangle----------------------------------------

            CigarParty party = new CigarParty();

            //----Act-----------------------------------------------

            //break these into separate methods or just use DataTestMethod
            bool isABanger1 = party.HaveParty(100, true);
            bool isABanger4 = party.HaveParty(45, false);

            //----Assert-------------------------------------------

            Assert.AreEqual(true, isABanger1);
            Assert.AreEqual(true, isABanger4);
        }

        [TestMethod]
        public void IsThePartyAHit_EdgeCases()
        {
            //----Arrangle----------------------------------------

            CigarParty party = new CigarParty();

            //----Act-----------------------------------------------

            //break these into separate methods or just use DataTestMethod
            
            bool isABanger2 = party.HaveParty(40, true);
            bool isABanger3 = party.HaveParty(60, false);
            bool isABanger4 = party.HaveParty(40, false);

            //----Assert-------------------------------------------

            
            Assert.AreEqual(true, isABanger2);
            Assert.AreEqual(true, isABanger3);
            Assert.AreEqual(true, isABanger4);
        }

        [TestMethod]
        public void IsThePartyAHit_OutsideRange()
        {
            //----Arrangle----------------------------------------

            CigarParty party = new CigarParty();

            //----Act-----------------------------------------------

            //break these into separate methods or just use DataTestMethod
            bool isABanger1 = party.HaveParty(100, false);
            bool isABanger2 = party.HaveParty(20, true);
            bool isABanger3 = party.HaveParty(70, false);
            bool isABanger4 = party.HaveParty(0, true);

            //----Assert-------------------------------------------

            Assert.AreEqual(false, isABanger1);
            Assert.AreEqual(false, isABanger2);
            Assert.AreEqual(false, isABanger3);
            Assert.AreEqual(false, isABanger4);
        }

        [TestMethod]
        public void IsThePartyAHit_Negative()
        {
            //----Arrangle----------------------------------------

            CigarParty party = new CigarParty();

            //----Act-----------------------------------------------

            //break these into separate methods or just use DataTestMethod
            bool isABanger1 = party.HaveParty(-10, true);


            //----Assert-------------------------------------------

            Assert.AreEqual(false, isABanger1);

        }

    }
}
