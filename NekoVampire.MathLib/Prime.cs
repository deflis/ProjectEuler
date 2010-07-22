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
            if (primes.Any(y => x % y == 0))
                return false;
            long n = (long)Math.Floor(Math.Sqrt(x));
            if (n > max)
            {
                lock (primes)
                {
                    foreach (var i in max.UpTo(n))
                    {
                        max = i;
                        if (primes.AsParallel().All(y => i % y != 0))
                        {
                            primes.Add(i);
                            if (x % i == 0)
                                return false;
                        }
                    }
                }
            }
            return true;
        }

        public IEnumerable<long> Primes()
        {
            var copy = primes.ToArray();
            return copy.Concat(max.UpToInfinity().AsParallel().AsOrdered().Where(IsPrime));
        }
    }
}
