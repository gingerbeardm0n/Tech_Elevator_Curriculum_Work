using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char). 
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            Console.WriteLine("First and Last Character. ");
            char first = name[0];
            Console.WriteLine(first);
            Console.WriteLine(name[name.Length -1]);
            

          

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

        
            Console.WriteLine("First 3 characters: " + name.Substring(0,3));

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            Console.WriteLine("First 3 characters: " + name.Substring(0, 3));
            Console.WriteLine("Last 3 characters: " + name.Substring(name.Length-3, 3));

            // 4. What about the last word?
            // Output: Lovelace

            string[] result = name.Split(' ');
            string lastName = result[1];

            Console.WriteLine("Last Word: " + lastName);

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            bool contains = name.Contains("Love");

            Console.WriteLine("Contains \"Love\"");

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            int position = name.IndexOf("lace");

            Console.WriteLine("Index of \"lace\": " + position);

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            int counter = 0;
            string testName = name.ToLower();
            for (int i = 0; i < name.Length; i++)
            {
                if (testName.Substring(i, 1) == "a")
                {
                    counter++;
                }
            }

            Console.WriteLine("Number of \"a's\": " + counter);

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"


            Console.WriteLine(name.Replace("Ada", "Ada, Countess of Lovelace"));

            // 9. Set name equal to null.
            name = null;

            //Console.WriteLine(name.Length);
            
            // 10. If name is equal to null or "", print out "All Done".

            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("All Done.");
            }

            Console.ReadLine();
        }
    }
}