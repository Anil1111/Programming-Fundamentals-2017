using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToList();
            var dictionary = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!dictionary.ContainsKey(letter))
                {
                    dictionary[letter] = 0;

                }
                dictionary[letter]++;
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
