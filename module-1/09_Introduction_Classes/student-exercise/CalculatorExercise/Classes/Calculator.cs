using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        public int Result { get; private set; }

        public int Add(int addend)
        {
            Result += addend;
            return Result;
        }
        public int Multiply(int multiplier)
        {
            Result = Result * multiplier;
            return Result;
        }
        public int Power(int exponent)
        {
            double doubleResult = (double)Result;
            double doubleExponent = (double)exponent;
            doubleResult = Math.Pow(doubleResult, doubleExponent);
            int tempResult = Convert.ToInt32(doubleResult);
            Result = tempResult;
            return Result;
        }
        public void Reset()
        {
            Result = 0;
        }
        public int Subtract(int subtrahend)
        {
            Result -= subtrahend;
            return Result;
        }

    }
}
