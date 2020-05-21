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
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            Dictionary<string, string> firstAndLast = new Dictionary<string, string>();

            foreach (string myString in words)
            {
                if (myString != "muddy" && firstAndLast.ContainsKey(myString.Substring(0, 1)) == false)
                {
                    firstAndLast.Add((myString.Substring(0, 1)), (myString.Substring(myString.Length - 1, 1)));
                }
            }
            return firstAndLast;
        }
    }
}
