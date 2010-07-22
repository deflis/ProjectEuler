using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Achiral;
using Achiral.Extension;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", 1.UpTo(1000 - 1).Where(x => x % 3 == 0 | x % 5 == 0).Sum());
            Console.ReadKey();
        }
    }
}
