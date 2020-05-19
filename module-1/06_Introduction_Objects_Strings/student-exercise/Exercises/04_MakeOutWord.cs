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
         Given an "outword" string length 4, such as "<<>>", and a word, return a new string where the word is in the
         middle of the outword string, e.g. "<<word>>". Note: use str.Substring(i, j) to extract the string starting
         at index i and going up to but not including index j.
         MakeOutWord("<<>>", "Yay") → "<<Yay>>"
         MakeOutWord("<<>>", "WooHoo") → "<<WooHoo>>"
         MakeOutWord("[[]]", "word") → "[[word]]"
         */
        public string MakeOutWord(string outword, string word)
        {
            
            string firstTwoChars = outword.Substring(0, 2);
            string secondTwoChars = outword.Substring(2, 2);

            //Console.WriteLine(firstTwoChars);
            //Console.WriteLine(secondTwoChars);
            //Console.WriteLine(word);

            return firstTwoChars + word + secondTwoChars;

            //Console.ReadLine();
        }
    }
}
