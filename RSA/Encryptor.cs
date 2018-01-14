using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    public class Encryptor
    {
        public BigInteger encrypt(BigInteger message, PublicKey publicKey)
        {
            return BigInteger.ModPow(message, publicKey.e, publicKey.N);
        }
    }
}
