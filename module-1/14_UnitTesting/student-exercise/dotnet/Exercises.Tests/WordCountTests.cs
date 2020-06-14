using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        //WordCount testObj;

        //[TestInitialize]
        //public void Init()
        //{
        //    testObj = new WordCount();
        //}

        [TestMethod]
        //[DataRow(new string[] { "ba", "ba", "black", "sheep" }, new Dictionary<string, int> { "ba" : 2, "black": 1, "sheep": 1 })]

        public void PassInExampleFromProblem()
        {
            //------ Arrange -------------------------------------------------------

            WordCount mattIsTheJavaBatMan = new WordCount();
            Dictionary<string, int> mattsSneakyDictionary1 = new Dictionary<string, int>();

            //----Act-----------------------------------------------
            //new string[] words = null;
            
            mattsSneakyDictionary1 = mattIsTheJavaBatMan.GetCount(new string[]{"ba", "ba", "black", "sheep" });
            
            //----Assert-------------------------------------------

            //Assert.ReferenceEquals((new Dictionary<string, int> { "ba" : 2, "black": 1, "sheep": 1 }), mattsSneakyDictionary1);


        }
    }
}
