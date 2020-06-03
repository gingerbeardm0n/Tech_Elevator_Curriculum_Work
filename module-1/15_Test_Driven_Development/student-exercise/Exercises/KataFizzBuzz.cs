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
            string output = n.ToString();
            
            if (n < 1 || n > 100)
            {
                output = "";
                return output;
            }
            if ((n % 5 == 0 && n % 3 == 0) || (output.Contains("3") && output.Contains("5")))
            {
                output = "FizzBuzz";
            }
            else if ((n % 5 == 0) || (output.Contains("5")) )
            {
                output = "Buzz";
            }
            else if ((n % 3 == 0) || (output.Contains("3")) )
            {
                output = "Fizz";
            }
            return output;
        }
    }
}
