﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            //int stringCounter1 = 1;

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            if (words.Length == 0)
            {
                return null;
            }

            else
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (myDictionary.ContainsKey(words[i]))
                    {
                        //stringCounter1++;
                        myDictionary[(words[i])]++;
                    }
                    else
                    {
                        myDictionary.Add((words[i]), 1);
                    }
                }
            }





            return myDictionary;


        }
    }
}

/*for (int j = 1; j < words.Length-1; j++)
                {
                if (words[i] == words[j])
                    {
                        stringCounter1++; 8 */
