using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem22
{
    class Program
    {
        static void Main(string[] args)
        {
            var names_txt = File.OpenText("names.txt").ReadToEnd();
            List<string> names = new List<string>(
                names_txt.Split(',')
                .Select(x => x.Substring(1,x.Length-2)));
            names.Sort();
            var score = new Dictionary<char, long>();
            Console.WriteLine("{0}", names
                .Select( (name,index) => new{name,index})
                .Select(x =>
                    x.name.Select(y => y - 'A' + 1).Sum() * (x.index +1))
                .Sum());

            Console.ReadKey();
        }
    }
}
