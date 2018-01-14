using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    public class SecretKey
    {
        public SecretKey(BigInteger d)
        {
            _d = d;
        }

        public BigInteger d
        {
            get { return _d; }
        }
    

        private BigInteger _d;
    }
}
