﻿using System;
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

            return null;
        }
    }
}
