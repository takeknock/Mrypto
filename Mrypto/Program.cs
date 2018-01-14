using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Mrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            //KeyGen

            RSA.KeyGen generator = new RSA.KeyGen();
            generator.initialize();
            Tuple<RSA.PublicKey, RSA.SecretKey> keys = generator.createKeys();
            RSA.PublicKey publicKey = keys.Item1;
            RSA.SecretKey secretKey = keys.Item2;
            Console.WriteLine(keys.ToString());

            //Encryption
            //1. calculate c = m^e mod N
            RSA.Encryptor enc = new RSA.Encryptor();
            BigInteger message = 12;
            BigInteger encryptedMessage = 
                enc.encrypt(message, publicKey);

            //Decription
            //1. m' = c^d mod N
            RSA.Decryptor dec = new RSA.Decryptor();

            BigInteger decryptedMessage =
                dec.decrypt(encryptedMessage, publicKey, secretKey);

            //Check m==m'
            Console.WriteLine("m==m': " + (encryptedMessage == decryptedMessage).ToString());
        }
    }
}
