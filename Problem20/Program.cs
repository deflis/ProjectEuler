using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Achiral;
using Achiral.Extension;
using System.Numerics;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", ((BigInteger)1).UpTo(100)
                .Aggregate((x, y) => x * y)
                .ToString()
                .Select(x => x - '0')
                .Sum());
            Console.ReadKey();
        }
    }
}
