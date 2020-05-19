using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
         StringBits("Hello") → "Hlo"
         StringBits("Hi") → "H"
         StringBits("Heeololeo") → "Hello"
         */
        public string StringBits(string str)
        {

            if (str.Length == 0)
            {
                return "";
            }
            else if (str.Length == 1)
            {
                return str;
            }

            else
            {

            string newString = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i%2 == 0)
                {
                    newString = newString + str.Substring(i, 1);
                return newString;
                }
                
            }
            }
        }
    }
}
