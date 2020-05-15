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
         Return the sum of the numbers in the array, returning 0 for an empty array. Except the number
         13 is very unlucky, so it does not count and numbers that come immediately after a 13 also do
         not count.
         Sum13([1, 2, 2, 1]) → 6
         Sum13([1, 1]) → 2
         Sum13([1, 2, 2, 1, 13]) → 6
         */
        public int Sum13(int[] nums)
        {

            int sumOfArray = 0;

            for (int i = 0; i <= nums.Length-1; i++)
            {
                if (nums[i] != 13)
                {
                    sumOfArray = sumOfArray + nums[i];
                }
                else
                {
                    nums[i] = 0;
                    sumOfArray = sumOfArray + nums[i];
                    i = i + 1;
                } 
            }
            {
                return sumOfArray;
            
            }
        }

    }
}
