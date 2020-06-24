using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
   
    public class KataPrimeFactors
    {
        public List<int> Factorize(int n)
        {
            List<int> factorsList = new List<int>();
            if (n == 2)
            {
                factorsList.Add(n);
                return factorsList;
            }
            else if (n == 3)
            {
                factorsList.Add(n);
                return factorsList;
            }
            else if (n%2 == 0)
            {
                factorsList.Add(2);

                int m = n / 2;
                if (m%2 == 0)
                {
                    factorsList.Add(2);
                    factorsList.Add(m / 2);
                }
                
                return factorsList;
            }
            else if (n == 7)
            {
                factorsList.Add(n);
                return factorsList;
            }

            return null;
        }
    }
}
