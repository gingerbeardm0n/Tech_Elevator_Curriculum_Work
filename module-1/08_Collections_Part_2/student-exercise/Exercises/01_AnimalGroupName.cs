using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> animalPedia = new Dictionary<string, string>();

            animalPedia.Add("RHINO", "Crash");
            animalPedia.Add("GIRAFFE", "Tower");
            animalPedia.Add("ELEPHANT", "Herd");
            animalPedia.Add("LION", "Pride");
            animalPedia.Add("CROW", "Murder");
            animalPedia.Add("PIGEON", "Kit");
            animalPedia.Add("FLAMINGO", "Pat");
            animalPedia.Add("DEER", "Herd");
            animalPedia.Add("DOG", "Pack");
            animalPedia.Add("CROCODILE", "Float");

            string upperCaseAnimal = animalName.ToUpper();

            if (animalPedia.ContainsKey(upperCaseAnimal) == true)
            {
                return animalPedia[upperCaseAnimal];
            }
            else
            {
                return "unknown";
            }
        }
    }
}
