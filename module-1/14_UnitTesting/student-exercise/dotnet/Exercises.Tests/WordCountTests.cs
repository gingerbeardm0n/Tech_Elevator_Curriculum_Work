using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
       
        [TestMethod]
      
        public void WordCountTest_IsTheBaneOfMyExistence()
        {
            //------ Arrange -------------------------------------------------------

            WordCount mattIsTheJavaBatMan = new WordCount();
            Dictionary<string, int> mattsSneakyDictionary = new Dictionary<string, int>();

            //----Act-----------------------------------------------
            //new string[] words = null;
            
            mattsSneakyDictionary = mattIsTheJavaBatMan.GetCount(new string[]{"ba", "ba", "black", "sheep" });

            //----Assert-------------------------------------------
            
            Assert.AreEqual(2, mattsSneakyDictionary["ba"]);
            Assert.AreEqual(1, mattsSneakyDictionary["black"]);
            Assert.AreEqual(1, mattsSneakyDictionary["sheep"]);
            Assert.AreEqual(3, mattsSneakyDictionary.Count);
            
        }
    }
}
