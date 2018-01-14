using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    public class Decryptor
    {
        public BigInteger decrypt(
            BigInteger encryptedMessage, PublicKey publicKey, SecretKey secretKey)
        {
            BigInteger decryptedMessage =
                BigInteger.ModPow(encryptedMessage, secretKey.d, publicKey.N);

            return decryptedMessage;
        }
    }
}
