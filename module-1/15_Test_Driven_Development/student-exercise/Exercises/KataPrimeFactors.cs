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
            //if (n == 2 || n == 3 || n == 7)
            //{
            //    factorsList.Add(n);
            //    return factorsList;
            //}
            //else if (n % 2 == 0)
            //{
            //    factorsList.Add(2);
            //    n = n / 2;
            //    if (n % 2 == 0)
            //    {
            //        factorsList.Add(2);
            //        factorsList.Add(n / 2);
            //    }
            //    else if (n % 3 == 0)
            //    {
            //        factorsList.Add(3);
            //        n = n / 3;
            //    }
            //    factorsList.Add(n);
            //    return factorsList;
            //}
            //else if (n % 3 == 0)
            //{
            //    factorsList.Add(3);
            //    int m = n / 3;
            //    factorsList.Add(m);
            //    return factorsList;
            //}


            bool done = false;
            while (!done)
            {
                if (n % 2 == 0 && n != 2)
                {
                    factorsList.Add(2);
                    n = n / 2;
                }
                else if (n % 3 == 0 && n != 3)
                {
                    factorsList.Add(3);
                    n = n / 3;
                }
                else if (n % 5 == 0 && n != 5)
                {
                    factorsList.Add(5);
                    n = n / 5;
                }
                else if (n % 7 == 0 && n != 7)
                {
                    factorsList.Add(3);
                    n = n / 7;
                }
                else if (n == 2 || n == 3 || n == 5 || n == 7)
                {
                    factorsList.Add(n);
                    done = true;
                }
            }
            return factorsList;

            
        }
    }
}
