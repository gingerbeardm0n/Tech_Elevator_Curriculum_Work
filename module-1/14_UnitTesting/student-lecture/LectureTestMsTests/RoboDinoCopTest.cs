using Lecture.Farming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace LectureTestMsTests
{
    [TestClass]
    public class RoboDinoCopTest
    {
        [TestMethod]
        public void RoboDinoCopNameShouldBeTriceroCops()
        {
            // Arrange - setting up code
            RobotDinosaurPoliceOfficer cop = new RobotDinosaurPoliceOfficer();
            cop.IsAsleep = true;

            // Act - acting on the thing were testing

            string name = cop.Name;

            // Assert - verify the behavior

            Assert.AreEqual("RoboCoptor", name, "Dude, you don't know how to remember names");
        }
        [TestMethod]
        public void RoboDinoCopShouoldSnoreWhenAsleep()
        {
            //arrange
            RobotDinosaurPoliceOfficer cop = new RobotDinosaurPoliceOfficer();
            cop.IsCaffenated = true;
            
            //act
            string sound = cop.MakeSoundOnce();
            //assert
            Assert.AreEqual("RED BULL???", sound);
        }

        [TestMethod]
        public void RoboDinoCopShouldStartAsleep()
        {
            //arrange
            RobotDinosaurPoliceOfficer cop = new RobotDinosaurPoliceOfficer();

            //act - no action is needed

            //assert
            Assert.IsTrue(cop.IsAsleep, "Cop didnt start asleep");


            if (!cop.IsAsleep)
            {
            Assert.Fail("Dude, the cop should start asleep, its awake.");
            }

        }





    }



}
