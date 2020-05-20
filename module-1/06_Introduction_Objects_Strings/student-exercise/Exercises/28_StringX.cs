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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            if (str == "")
            {
                return "";
            }
            else if (str == "xx")
            {
                return "xx";
            }
            else if (str == "x")
            {
                return "x";
            }
            else
            {
                string startingChar = str.Substring(0, 1);
                string middleBits = str.Substring(1, str.Length - 2);
                string lastButNotLeast = str.Substring(str.Length - 1, 1);
                string middleBitsGeeRated = middleBits.Replace("x", "");
                string getTheGangBackTogetherAgain = startingChar + middleBitsGeeRated + lastButNotLeast;

                return getTheGangBackTogetherAgain;
            }
        }

    }
}



/* if (str == "")
            {
                return "";
            }
            else if (str == "xx")
            {
                return "xx";
            }
            else if (str == "x")
            {
                return "x";
            }
            else
            {
                string geeRatedString = "";

                for (int i = 1; i<str.Length - 1; i++)
                {
                    if (str.Substring(i, 0) == "x")
                    {
                        geeRatedString = str.Remove(i, 1);
                    }

                }
                return geeRatedString;

            }
    */
