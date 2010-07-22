using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Achiral.Extension;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 999.DownTo(100);
            Console.WriteLine("{0}", n.product(n, (x, y) => x * y).Where(IsPalindrome).Max());
            Console.ReadKey();
        }

        static bool IsPalindrome(int x)
        {
            var str = x.ToString("0");
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            return true;
        }

        static IEnumerable<int> CreatePalindrome(int max)
        {
            foreach (var p in max.DownTo(100).AsParallel().Where(IsPalindrome))
                yield return p;
        }
    }

    static class Extension
    {
        static public IEnumerable<TResult> product<T1, T2, TResult>(this IEnumerable<T1> eumerable1, IEnumerable<T2> eumerable2, Func<T1, T2, TResult> func)
        {
            foreach (var x in eumerable1)
                foreach (var y in eumerable2)
                    yield return func(x, y);
        }
    }
}
