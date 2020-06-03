using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class KataFizzBuzzTests
    {
        KataFizzBuzz testObj;

        [TestInitialize]
        public void Init()
        {
            testObj = new KataFizzBuzz();
        }

        [DataTestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(-9, "Fizz")]
        [DataRow(1, "1")]
        [DataRow(71, "71")]
        [DataRow(15, "Buzz")]//might need to change this later
        [DataRow(108, "Fizz")]//might need to change this later
        [DataRow(300, "Buzz")]//might need to change this later
        public void DivisibleByJustThree(int input, string expectedResult)
        {
            //----Act-----------------------------------------------
            string result = testObj.ConvertFizzBuzz(input);
            //----Assert--------------------------------------------
            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow(5, "Buzz")]
        [DataRow(-10, "Buzz")]
        [DataRow(0, "Buzz")]
        [DataRow(61, "61")]
        [DataRow(15, "Buzz")]//might need to change this later
        [DataRow(110, "Buzz")]//might need to change this later
        [DataRow(300, "Buzz")]//might need to change this later
        public void DivisibleByJustFive(int input, string expectedResult)
        {
            //----Act-----------------------------------------------
            string result = testObj.ConvertFizzBuzz(input);
            //----Assert--------------------------------------------
            Assert.AreEqual(expectedResult, result);
        }


    }
}
