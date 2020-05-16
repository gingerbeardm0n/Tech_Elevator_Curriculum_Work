using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of integers (but please sepatate each integer with a space).");
            string seriesAsString = Console.ReadLine();
            
            string[] separatedIntegersAsStrings = seriesAsString.Split(' ');

            for (int i = 0; i < separatedIntegersAsStrings.Length; i++)
            {
                int separatedIntegerActuallyAsInteger = int.Parse(separatedIntegersAsStrings[i]);
                string separatedBinaryString = Convert.ToString(separatedIntegerActuallyAsInteger, 2);
                //Console.WriteLine(separatedIntegerActuallyAsInteger);
                //Console.WriteLine(separatedBinaryString);
                Console.WriteLine("The integer " + separatedIntegerActuallyAsInteger + " translated to binary is..... drumroll please..... " + separatedBinaryString);
            }


            


            Console.ReadLine();
        }
    }
}
