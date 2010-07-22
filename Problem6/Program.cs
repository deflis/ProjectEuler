using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Achiral.Extension;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 1.UpTo(100);

            Console.WriteLine("{0}", Math.Pow(n.Sum(), 2) - n.Select(x => Math.Pow(x, 2)).Sum());
            Console.ReadKey(); 
        }
    }
}
