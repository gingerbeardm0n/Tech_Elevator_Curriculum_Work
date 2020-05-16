using System;

namespace LinearConvert
{
    class Program
    {



        static void Main(string[] args)
        {
            double finalLength = 0;
            double convertedFeet = 0;
            double convertedMeters = 0;

            
            Console.WriteLine("Please enter a length!");
            string userInput = Console.ReadLine();
            double length = double.Parse(userInput);

            Console.WriteLine("Please specify if it's meters or feet (M/F)");
            string measurmentType = Console.ReadLine();
            

            switch (measurmentType)
            {
                case "M":
                case "m":
                    convertedFeet = length * 3.2808399;
                    Console.WriteLine("The input was " + length + " and the ouput is " + convertedFeet);
                    break;
                case "F":
                case "f":
                    
                    convertedMeters = length * 0.3048;
                    Console.WriteLine("The input was " + length + " and the ouput is " + convertedMeters);
                    break;
                default:
                    Console.WriteLine("hey dumba$$, please start over and try again");
                    break;
            }

            

            Console.ReadLine();
        }

            
    }
}
