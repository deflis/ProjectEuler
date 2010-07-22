using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NekoVampire.MathLib;
using Achiral.Extension;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            var prime = new Prime();
            var primes = prime.Primes();

            Console.WriteLine("{0}", 2000000.DownTo(2).Where(x => prime.IsPrime(x)).Aggregate((System.Numerics.BigInteger)0, (x, y) => x + y));
            Console.ReadKey();
        }
    }
}
