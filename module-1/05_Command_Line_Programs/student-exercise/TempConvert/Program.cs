using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double convertedFahrenheit = 0;
            double convertedCelcius = 0;


            Console.WriteLine("Please enter a temperature!");
            string userInput = Console.ReadLine();
            double temp = double.Parse(userInput);

            Console.WriteLine("Please specify if it's Fahrenheit or Celcius (F/C)");
            string temperatureType = Console.ReadLine();


            switch (temperatureType)
            {
                case "F":
                case "f":
                    convertedCelcius = (temp - 32) /1.8;
                    Console.WriteLine("The input was " + temp + " and the ouput is " + convertedCelcius);
                    break;
                case "C":
                case "c":
                    convertedFahrenheit = (temp * 1.8) + 32;
                    Console.WriteLine("The input was " + temp + " and the ouput is " + convertedFahrenheit);
                    break;
                default:
                    Console.WriteLine("you dumbass, try again");
                    break;
            }



            Console.ReadLine();
        }
    }
}
