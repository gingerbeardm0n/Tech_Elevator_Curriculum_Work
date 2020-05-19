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
         Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, but
         the "a" can be any char. The "yak" strings will not overlap.
         StringYak("yakpak") → "pak"
         StringYak("pakyak") → "pak"
         StringYak("yak123ya") → "123ya"
         */

        public string StringYak(string str)
        {

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {

                if (i >= str.Length - 2)
                {
                    result += str.Substring(i, 1);
                }

                else if (str.Substring(i, 1) == "y" && str.Substring(i + 2, 1) == "k")
                {
                    i++;
                    i++;
                }

                else
                {
                    result += str.Substring(i, 1);
                }
            }
            return result;
        }
    }
}
