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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            if (str.Length < 2)
            {
                return false;
            }
            else if ( str.IndexOf("x") == str.Length -1 )
            {
                return false;
            }
            else if (str.Contains("x"))
            {
                
                int firstExIndex = str.IndexOf("x");

                string firstEx = str.Substring(firstExIndex, 1);
                string secondEx = str.Substring((firstExIndex + 1), 1);

                if (firstEx == secondEx)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            else
            {
                return false; 
                
            }
        }
    }
}
