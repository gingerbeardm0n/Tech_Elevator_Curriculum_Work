using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string ConvertFizzBuzz(int n)
        {
            string output = "Fizz";
            
            if (n % 5 == 0 && n % 3 == 0)
            {
                output = "FizzBuzz";
                return output;
            }
            else if (n % 5 == 0)
            {
                output = "Buzz";
                return output;
            }
            else if (n % 3 != 0)
            {
                string nString = n.ToString();
                return nString;
            }
            return output;
        }
    }
}
