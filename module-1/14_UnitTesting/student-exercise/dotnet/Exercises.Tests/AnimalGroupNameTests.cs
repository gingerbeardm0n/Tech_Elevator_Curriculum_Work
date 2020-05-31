using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {

        [TestMethod]
        public void DoesGetHerdCallTheRightValueWhenTheKeyIsPassedIn()
        {
            //----Arrangle----------------------------------------
            AnimalGroupName testAnimal = new AnimalGroupName();


            //----Act-----------------------------------------------
            string testKey1 = testAnimal.GetHerd("rhino");
            string testKey2 = testAnimal.GetHerd("");
            string testKey3 = testAnimal.GetHerd("walrus");
            string testKey4 = testAnimal.GetHerd("Rhino");
            string testKey5 = testAnimal.GetHerd("elephants");
            string testKey6 = testAnimal.GetHerd("ELePhaNt");
            string testKey7 = testAnimal.GetHerd("gir affe");
            string testKey8 = testAnimal.GetHerd("CROW");
            string testKey9 = testAnimal.GetHerd("dogdog");


            //----Assert-------------------------------------------

            Assert.AreEqual("Crash", testKey1);
            Assert.AreEqual("unknown", testKey2);
            Assert.AreEqual("unknown", testKey3);
            Assert.AreEqual("Crash", testKey4);
            Assert.AreEqual("unknown", testKey5);
            Assert.AreEqual("Herd", testKey6);
            Assert.AreEqual("unknown", testKey7);
            Assert.AreEqual("Murder", testKey8);
            Assert.AreEqual("unknown", testKey9);

        }



    }
}
