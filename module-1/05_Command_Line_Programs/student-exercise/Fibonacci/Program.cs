﻿using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a single positive integer value, which will decide how high the Fibonacci sequence will display.");
            string userInput = Console.ReadLine();
            int upperLimitInteger = int.Parse(userInput);

            if (upperLimitInteger < 0)
            {
                Console.WriteLine("Nice 1st attempt, but please start over and enter a POSITIVE integer value.");
                Console.ReadLine();
            }
            else if (upperLimitInteger == 0)
            {
                Console.WriteLine("0");
                Console.ReadLine();
            }
            else if (upperLimitInteger == 1)
            {
                Console.WriteLine("0, 1, 1");
                Console.ReadLine();
            }
            else
            {

                int[] loopingArray;
                loopingArray = new int[upperLimitInteger+1];

                for (int i = 0; i < upperLimitInteger+1; i++)
                {
                    loopingArray[i] = i;
                }

                Console.WriteLine(loopingArray);
                Console.WriteLine(loopingArray[0]);
                Console.WriteLine(loopingArray[1]);
                Console.WriteLine(loopingArray[upperLimitInteger-1]);
                Console.WriteLine(loopingArray[upperLimitInteger]);


                int n = 0;
                int[] fibArray;
                fibArray = new int[n];
                fibArray[0] = 0;
                fibArray[1] = 1;
                fibArray[2] = 1;

                //for (int i = 0; i < upperLimitInteger+1; i++)
                //{
                //    if (loopingArray[i]) ==  
                //}




                Console.ReadLine();


                //int numberOfIndices = upperLimitInteger;
                // emptyButDefinedNumberOfIndiciesArray ==> emptyButDefined
                //int[] emptyButDefined = new int[numberOfIndices];

                //int[] startingArray = { 0, 1, 1 };
                //for (int i = 2; i < emptyButDefined.Length; i++)
                //{
                //    if (emptyButDefined[i] == emptyButDefined[i-1] + emptyButDefined[i-2])
                //    {

                //    }
            }
            }


            
        }
    }

