using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Achiral.Extension;

namespace NekoVampire.MathLib
{
    public class Prime
    {
        List<long> primes;
        long max = 10;

        public Prime()
        {
            primes = new List<long> { 2, 3, 5, 7 };
        }

        public bool IsPrime(long x)
        {
            if (x < max)
                return primes.Contains(x);
            if (primes.AsParallel().Any(y => x % y == 0))
                return false;
            foreach (var i in max.UpTo((long)Math.Floor(Math.Sqrt(x))))
            {
                max = i;
                if (primes.AsParallel().All(y => i % y != 0))
                {
                    primes.Add(i);
                    if (x % i == 0)
                        return false;
                }
            }
            return true;
        }

        public IEnumerable<long> Primes()
        {
            var copy = primes.ToArray();
            return copy.Concat(max.UpToInfinity().Where(IsPrime));
        }
    }
}
