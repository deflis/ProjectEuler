using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Achiral.Extension;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 2520.UpToInfinity();
            Console.WriteLine("{0}", n.AsParallel().Where(
                x =>
                    ! 2.UpTo(20)
                    .Any(y =>
                        x % y != 0)
                    ).First());
            Console.ReadKey(); 
        }
    }
}
