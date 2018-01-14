using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    public class KeyGen
    {
        public void initialize()
        {

        }

        public Tuple<PublicKey, SecretKey> createKeys()
        {
            //1.Generate prime numbers, $p$ and $q$.
            RSA.PrimeNumberFactory gen = new RSA.PrimeNumberFactory();
            Random random = new Random(1000);
            Random random2 = new Random(1001);
            int length = 2;
            BigInteger p = gen.generatePrimeNumber(random, length);
            // FIX: Bad Basic Design
            BigInteger q = gen.generatePrimeNumber(random2, length);
            Console.WriteLine("p : " + p.ToString());
            Console.WriteLine("q : " + q.ToString());

            //2. N = pq
            BigInteger N = p * q;
            Console.WriteLine("N : " + N.ToString());

            //3. Choose $e$ which satisfies GCD((p-1), (q-1), e) = 1
            BigInteger e = calculateE(p, q);
            //4. Calculate $d$ which satisfies ed = 1 mod (p-1)(q-1)
            BigInteger d = calculateD(e, p, q);
            //5. PublicKey=(N, e), SecretKey=d
            KeyFactory factory = new KeyFactory();
            PublicKey publicKey = factory.createPublicKey(N, e);
            SecretKey secretKey = factory.createSecretKey(d);

            return new Tuple<PublicKey, SecretKey>(publicKey, secretKey);
        }

        private BigInteger calculateE(BigInteger p, BigInteger q)
        {
            // Not Implemented
            return 1;
        }

        private BigInteger calculateD(BigInteger e, BigInteger p, BigInteger q)
        {
            // Not Implemented
            return 1;
        }

    }
}
