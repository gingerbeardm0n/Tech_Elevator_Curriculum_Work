using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [DataRow(15, "Fizz")]//might need to change this later
        [DataRow(108, "Fizz")]//might need to change this later
        [DataRow(300, "Fizz")]//might need to change this later
        public void DivisibleByJustThree(int input, string expectedResult)
        {
            //----Act-----------------------------------------------
            string result = testObj.ConvertFizzBuzz(input);
            //----Assert--------------------------------------------
            Assert.AreEqual(expectedResult, result);
        }
    }
}
