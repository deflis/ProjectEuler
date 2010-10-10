using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", BigInteger.Pow(2, 1000)
                .ToString()
                .Sum(x => x - '0'));
            Console.ReadKey();
        }
    }
}
