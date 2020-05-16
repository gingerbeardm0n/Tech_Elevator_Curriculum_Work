using System;

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
            }
            else if (upperLimitInteger == 0)
            {
                Console.WriteLine("0");
            }
            else if (upperLimitInteger == 1)
            {
                Console.WriteLine("0, 1, 1");
            }
            else
            {


                int numberOfIndices = upperLimitInteger;
                // emptyButDefinedNumberOfIndiciesArray ==> emptyButDefined
                int[] emptyButDefined = new int[numberOfIndices];

                int[] startingArray = { 0, 1, 1 };
                for (int i = 2; i < emptyButDefined.Length; i++)
                {
                    if (emptyButDefined[i] == emptyButDefined[i-1] + emptyButDefined[i-2])
                    {

                    }
                }
            }


            Console.ReadLine();
        }
    }
}
