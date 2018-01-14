using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    public class PrimeNumberFactory
    {
        public BigInteger generatePrimeNumber(Random random, int length)
        {
            RandomNumberGenerator gen = RandomNumberGeneratorFactory.createGenerator(random);
            // FIX: do not create negative number.
            // FIX: create only odd number.
            BigInteger candidate = gen.generateRandomNumber(length);
            while(!Naive.isPrime(candidate))
            {
                Console.WriteLine("candidate: " + candidate.ToString());
                candidate = gen.generateRandomNumber(length);
            }

            return candidate;
        }
    }
}
