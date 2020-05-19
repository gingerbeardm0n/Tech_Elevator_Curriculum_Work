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
         Given a non-empty string like "Code" return a string like "CCoCodCode".
         StringSplosion("Code") → "CCoCodCode"
         StringSplosion("abc") → "aababc"
         StringSplosion("ab") → "aab"
         */
        public string StringSplosion(string str)
        {
            int stringLength = str.Length;

            string stringAttack = "";

            for (int i =1; i <= stringLength; i++)
            {
                stringAttack = stringAttack + str.Substring(0, i);
            }
            return stringAttack;
        }
    }
}
