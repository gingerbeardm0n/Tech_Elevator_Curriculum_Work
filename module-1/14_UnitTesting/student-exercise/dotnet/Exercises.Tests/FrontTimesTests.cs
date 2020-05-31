using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTests
    {
        [TestMethod]
        public void ThreeOrMoreCharsIsOutputCorrect()
        {   //----Arrangle----------------------------------------
            FrontTimes threeOrMore = new FrontTimes();
            
            //----Act-----------------------------------------------
            string testString1 = threeOrMore.GenerateString("JayBizzle", 4);
            string testString2 = threeOrMore.GenerateString("bAt", 1);
            string testString3 = threeOrMore.GenerateString("Mr.Matt Hates Java", 2);
            
            //----Assert-------------------------------------------
            Assert.AreEqual("JayJayJayJay", testString1);
            Assert.AreEqual("bAt", testString2);
            Assert.AreEqual("Mr.Mr.", testString3);

        }

        [TestMethod]
        public void TwoCharsIsOutputCorrect()
        {   //----Arrangle----------------------------------------
            FrontTimes twoChars = new FrontTimes();

            //----Act-----------------------------------------------
            string testString1 = twoChars.GenerateString("y0", 6);
            string testString2 = twoChars.GenerateString("??", 0);
            string testString3 = twoChars.GenerateString("HI", -2);

            //----Assert-------------------------------------------
            Assert.AreEqual("y0y0y0y0y0y0", testString1);
            Assert.AreEqual("", testString2);
            Assert.AreEqual("", testString3);

        }

        [TestMethod]
        public void OneCharIsOutputCorrect()
        {   //----Arrangle----------------------------------------
            FrontTimes oneChar = new FrontTimes();

            //----Act-----------------------------------------------
            string testString1 = oneChar.GenerateString("4", 16);
            
            //----Assert-------------------------------------------
            Assert.AreEqual("4444444444444444", testString1);
            
        }
        [TestMethod]
        public void EmptyStringIsOutputCorrect()
        {   //----Arrangle----------------------------------------
            FrontTimes emptyString = new FrontTimes();

            //----Act-----------------------------------------------
            string testString1 = emptyString.GenerateString("", 16);

            //----Assert-------------------------------------------
            Assert.AreEqual("", testString1);
        }
    }
}
