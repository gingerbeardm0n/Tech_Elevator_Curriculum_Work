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
         Given two lists of Integers, interleave them beginning with the first element in the first list followed
         by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
         Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
         list to the new list before returning it.
		 DIFFICULTY: HARD
         InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
         */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> myList = new List<int>();

            if (listOne.Count > listTwo.Count)
            {
                int i = 0;
                while (i < listTwo.Count)
                {
                    myList.Add(listOne[i]);
                    myList.Add(listTwo[i]);
                    i++;
                }
                int j = listTwo.Count;
                while (j < listOne.Count)
                {
                    myList.Add(listOne[j]);
                    j++;
                }

                return myList;
            }

            else if (listOne.Count < listTwo.Count)
            {
                int i = 0;
                while (i < listOne.Count)
                {
                    myList.Add(listOne[i]);
                    myList.Add(listTwo[i]);
                    i++;
                }
                int j = listOne.Count;
                while (j < listTwo.Count)
                {
                    myList.Add(listTwo[j]);
                    j++;
                }

                return myList;
            }

            else
            {
                int i = 0;
                while (i < listTwo.Count)
                {
                    myList.Add(listOne[i]);
                    myList.Add(listTwo[i]);
                    i++;
                }
                return myList;
            }


        }
    }
}
// [ listOne[0] , listTwo[0], listOne[1] , listTwo[1], listOne[2] , listTwo[2],   ]