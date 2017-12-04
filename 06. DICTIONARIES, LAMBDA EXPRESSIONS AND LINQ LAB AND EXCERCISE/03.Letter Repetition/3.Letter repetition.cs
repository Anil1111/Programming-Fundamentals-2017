using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Letter_repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToList();
            var result = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!result.ContainsKey(letter))
                { result[letter] = 0; }
                result[letter]++;

            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
