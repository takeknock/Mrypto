using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    public static class RandomNumberGeneratorFactory
    {
        public static RandomNumberGenerator createGenerator(Random random)
        {
            return new RandomNumberGenerator(random);
        }

    }
}
