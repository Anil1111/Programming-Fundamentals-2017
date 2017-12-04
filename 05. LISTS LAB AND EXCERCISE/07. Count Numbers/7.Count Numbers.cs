using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToList();
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (var number in input)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 1;
                }
                else
                    counts[number]++;
            }
            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
