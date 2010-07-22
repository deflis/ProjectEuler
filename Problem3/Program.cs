using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Achiral;
using Achiral.Extension;
using NekoVampire.MathLib;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 600851475143;

            var prime = new Prime();

            Console.WriteLine(((long)Math.Floor(Math.Sqrt(x))).DownTo(3).AsParallel().Where(prime.IsPrime).First(y => x % y == 0));

            Console.ReadKey();
        }
    }
}
