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
        [DataRow(15, "FizzBuzz")]
        [DataRow(108, "Fizz")]//might need to change this later
        [DataRow(300, "FizzBuzz")]
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
        [DataRow(0, "FizzBuzz")]
        [DataRow(61, "61")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(110, "Buzz")]
        [DataRow(300, "FizzBuzz")]//might need to change this later
        public void DivisibleByJustFive(int input, string expectedResult)
        {
            //----Act-----------------------------------------------
            string result = testObj.ConvertFizzBuzz(input);
            //----Assert--------------------------------------------
            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow(30, "FizzBuzz")]
        [DataRow(60, "FizzBuzz")]
        [DataRow(0, "FizzBuzz")]
        [DataRow(91, "91")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(110, "Buzz")]
        [DataRow(300, "FizzBuzz")]//might need to change this later
        public void DivisibleByThreeAndFive(int input, string expectedResult)
        {
            //----Act-----------------------------------------------
            string result = testObj.ConvertFizzBuzz(input);
            //----Assert--------------------------------------------
            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow(2, "2")]
        [DataRow(7, "7")]
        [DataRow(17, "17")]
        [DataRow(56, "56")]
        [DataRow(98, "98")]
        [DataRow(112, "112")]//might need to change this later
        [DataRow(167, "167")]//might need to change this later
        public void NotDivisibleBy3Or5ButUnder100(int input, string expectedResult)
        {
            //----Act-----------------------------------------------
            string result = testObj.ConvertFizzBuzz(input);
            //----Assert--------------------------------------------
            Assert.AreEqual(expectedResult, result);
        }
        [DataTestMethod]
        [DataRow(2, "2")]
        [DataRow(7, "7")]
        [DataRow(17, "17")]
        [DataRow(56, "56")]
        [DataRow(98, "98")]
        [DataRow(112, "")]//might need to change this later
        [DataRow(167, "")]//might need to change this later
        public void NotDivisibleBy3Or5ButOver100(int input, string expectedResult)
        {
            //----Act-----------------------------------------------
            string result = testObj.ConvertFizzBuzz(input);
            //----Assert--------------------------------------------
            Assert.AreEqual(expectedResult, result);
        }

    }
}
