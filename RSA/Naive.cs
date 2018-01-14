using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    public static class Naive
    {
        public static bool isPrime(BigInteger n)
        {
            if (n <= 1)
                return false;

            for (BigInteger i = 2; i < n - 1; ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
