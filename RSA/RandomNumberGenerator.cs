using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    public class RandomNumberGenerator
    {
        public RandomNumberGenerator(Random random)
        {
            _random = random;
        }

        public BigInteger generateRandomNumber(int length)
        {
            byte[] data = new byte[length];
            _random.NextBytes(data);
            return new BigInteger(data);
        }

        private Random _random;
    }
}
