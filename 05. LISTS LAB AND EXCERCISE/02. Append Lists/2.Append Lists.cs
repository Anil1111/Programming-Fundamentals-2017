using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split('|').ToList();
            var result = new List<string>(tokens.Count);

            for (int i = tokens.Count - 1; i >= 0; i--)
            {
                var currentSeq = tokens[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(currentSeq);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
