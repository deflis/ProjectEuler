using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Achiral;
using Achiral.Extension;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", fivonacchi(new[] { 1, 2 }, 4000000).Where(x => x % 2 == 0).Sum());
            Console.ReadKey();
        }

        static IEnumerable<long> fivonacchi(int[] start,long end)
        {
            long x = start[0], y = start[1];
            long ret = x + y;
            
            yield return x;
            yield return y;

            do
            {
                yield return ret;
                x = y;
                y = ret;
                ret = x + y;
            } while (ret < end);
        }
    }
}
