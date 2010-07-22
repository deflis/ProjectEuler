using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Achiral;
using Achiral.Extension;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 600851475143;

            var prime = new Prime();

            Console.WriteLine(((long)Math.Floor(Math.Sqrt(x))).DownTo(3).Where(prime.IsPrime).AsParallel().First(y => x % y == 0));

            Console.ReadKey();
        }

        class Prime
        {
            List<long> primes;
            long max = 10;

            public Prime()
            {
                primes = new List<long> { 2, 3, 5, 7 };
            }

            public bool IsPrime(long x)
            {
                if(x < max)
                    return primes.Contains(x);
                if (default(long) != primes.AsParallel().FirstOrDefault(y => x % y == 0))
                    return false;
                foreach(var i in max.UpTo((long)Math.Floor(Math.Sqrt(x))))
                {
                    max = i;
                    if (default(long) == primes.AsParallel().FirstOrDefault(y => i % y == 0))
                    {
                        primes.Add(i);
                        if (x % i == 0)
                            return false;
                    }
                }
                return true;
            }
        }
    }
}
