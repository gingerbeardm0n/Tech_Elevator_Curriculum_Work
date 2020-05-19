using System;
using System.Collections.Generic;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.
            //
            // The syntax used for declaring a new list of type T is
            //      List<T> list = new List<T>();
            //
            //

            // Creating lists of integers

            List<int> intValues = new List<int> { 3, 1, 4 };

            List<int> intValues2 = new List<int> { 3, 1, 4 };

            List<int> intValues3 = intValues2;

            // Creating lists of strings

            List<string> stringValues = new List<string>();
            
            

            /////////////////


            //////////////////
            // OBJECT EQUALITY
            //////////////////

            if (intValues2 == intValues3)
            {
                Console.WriteLine("They are equal ==");
            }
            else
            {
                Console.WriteLine("They are not equal ==");
            }

            if (intValues2.Equals(intValues3))
            {
                Console.WriteLine("They are equal in Equals");
            }
            else
            {
                Console.WriteLine("They are not equal in Equals");
            }
            /////////////////
            // ADDING ITEMS
            /////////////////

            // Adding items one at a time to each list
            Console.WriteLine(intValues.Count);
            intValues.Add(6);
            Console.WriteLine(intValues.Count);

            /////////////////
            // ADDING MULTIPLE ITEMS
            /////////////////



            //////////////////
            // ACCESSING BY INDEX
            //////////////////

            Console.WriteLine(intValues[0]);
            Console.WriteLine(intValues[intValues.Count -1]);


            ///////////////////
            // ACCESSING WITH FOR-EACH
            ///////////////////


            ////////////////////
            // ADDITIONAL LIST<T> METHODS
            ////////////////////


            ////////////////////////
            // SORT and PRINT A LIST
            ////////////////////////




            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow 
            //First -In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.


            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////

            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(5);
            myQueue.Enqueue(7);
            int result = myQueue.Peek();

            Console.WriteLine(myQueue);

            foreach (int item in myQueue)
            {
                Console.WriteLine(item);
            }

            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. 

            //FILO
            //LIFO

            ////////////////////
            // PUSHING ITEMS TO THE STACK
            //////////////////// 

            Stack<string> myStack = new Stack<string>();
            myStack.Push("first in");
            myStack.Push("second in");

            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }

            ////////////////////
            // POPPING THE STACK
            ////////////////////


            Console.ReadLine();

        }
    }
}
