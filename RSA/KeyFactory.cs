using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    public class KeyFactory
    {
        public PublicKey createPublicKey(BigInteger N, BigInteger e)
        {
            return new PublicKey(N, e);
        }

        public SecretKey createSecretKey(BigInteger d)
        {
            return new SecretKey(d);
        }

    }
}
