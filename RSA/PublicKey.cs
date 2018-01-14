﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    public class PublicKey
    {
        public PublicKey(BigInteger N, BigInteger e)
        {
            _N = N;
            _e = e;
        }

        private BigInteger _N;
        private BigInteger _e;
    }
}
