﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx".
         CountXX("abcxx") → 1
         CountXX("xxx") → 2
         CountXX("xxxx") →
         */
        public int CountXX(string str)
        {
            int counter = 0;


            if (str.Length <= 1)
            {
                return 0;
            }
            else
            {

            for (int i =0; i < str.Length-1; i++)
            {
                if ( (str.Substring(i,1) == "x") && (str.Substring(i+1, 1) == "x") )
                {
                    counter++;
                }
              
                }
                return counter;
            }

                

                }
            }
        }
  
