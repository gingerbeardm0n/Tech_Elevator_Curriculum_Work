using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        [TestMethod]
        public void IsItTrueWhenItsSupposedToBe()
        {   //----Arrangle----------------------------------------
            Less20 mattIsTheJavaBatMan = new Less20();


            //----Act-----------------------------------------------
            bool mattHasBetrayedUs1 = mattIsTheJavaBatMan.IsLessThanMultipleOf20(19);
            bool mattHasBetrayedUs2 = mattIsTheJavaBatMan.IsLessThanMultipleOf20(38);
            bool mattHasBetrayedUs3 = mattIsTheJavaBatMan.IsLessThanMultipleOf20(799);
            bool mattHasBetrayedUs4 = mattIsTheJavaBatMan.IsLessThanMultipleOf20(15);
            bool mattHasBetrayedUs5 = mattIsTheJavaBatMan.IsLessThanMultipleOf20(56841);
            


            //----Assert-------------------------------------------
            Assert.AreEqual(true, mattHasBetrayedUs1);
            Assert.AreEqual(true, mattHasBetrayedUs2);
            Assert.AreEqual(true, mattHasBetrayedUs3);
            Assert.AreEqual(false, mattHasBetrayedUs4);
            Assert.AreEqual(false, mattHasBetrayedUs5);
           



        }
        [TestMethod]
        public void NegativeNumberInputCheck()
        {   //----Arrangle----------------------------------------
            Less20 mattIsTheJavaBatMan = new Less20();


            //----Act-----------------------------------------------
            
            bool mattHasBetrayedUs6 = mattIsTheJavaBatMan.IsLessThanMultipleOf20(-20);


            //----Assert-------------------------------------------
          
            Assert.AreEqual(false, mattHasBetrayedUs6);



        }


    }
}
