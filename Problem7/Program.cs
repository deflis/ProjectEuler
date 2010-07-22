using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NekoVampire.MathLib;
using Achiral.Extension;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", new Prime().Primes().Skip(10000).First());
            Console.ReadKey(); 
        }
    }
}
