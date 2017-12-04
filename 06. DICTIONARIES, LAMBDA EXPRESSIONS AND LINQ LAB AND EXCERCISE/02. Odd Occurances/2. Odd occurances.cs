using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_occurances
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split().ToList();
            var result = new Dictionary<string, int>();
            var oddNumbers = new List<string>();

            foreach (var word in input)
            {
                if (!result.ContainsKey(word))
                { result[word] = 0; }
                result[word]++;
            }

            foreach (var kvp in result)
            {
                if (kvp.Value % 2 != 0)
                { oddNumbers.Add(kvp.Key); }
            }
            Console.WriteLine(string.Join(", ",oddNumbers));
        }
    }
}
