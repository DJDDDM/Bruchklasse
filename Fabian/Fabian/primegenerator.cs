using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace Fabian
{
    public class primegenerator
    {
        private const int lowestprime = 2;
        private List<int> primes;
        public primegenerator()
        {
            primes = new List<int>();
        }
        public int[] createupto(int maximum)
        {
            check_maximum_is_valid(maximum);
            fillprimes(maximum);
            return primes.ToArray();
        }

        private void fillprimes(int maximum)
        {
            for (int i = lowestprime; i <= maximum; i++)
            {
                if(so_far_not_divisible(i)) primes.Add(i);
            }
        }

        private bool so_far_not_divisible(int dividend)
        {
            foreach (int prime in primes)
            {
                if (dividend % prime == 0 ) return false;
            }
            return true;
        }

        private void check_maximum_is_valid(int maximum)
        {
            if (maximum < lowestprime) throw new ArgumentException();
        }
    }
}