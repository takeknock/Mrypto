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
            Console.WriteLine(keys.ToString());

            //Encryption
            //1. calculate c = m^e mod N

            //Decription
            //1. m' = c^d mod N



            //Check m==m'

        }
    }
}
