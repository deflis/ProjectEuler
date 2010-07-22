using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Achiral.Extension;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}",
                1.UpTo(998).SelectMany(
                a =>
                    (a + 1).UpTo(999).Where(
                        b =>
                            Math.Pow(1000 - a - b, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)
                    ).Select(
                        b =>
                            a * b * (1000 - a - b)
                        )
                ).Single());
            Console.ReadKey();
        }
    }
}
