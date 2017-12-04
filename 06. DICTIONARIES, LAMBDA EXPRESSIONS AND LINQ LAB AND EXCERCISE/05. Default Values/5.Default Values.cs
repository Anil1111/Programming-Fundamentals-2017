using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = new Dictionary<string,string>();
            var unchanged = new Dictionary<string, string>();
            var changed = new Dictionary<string, string>();
            while (tokens[0] != "end")
            {
                var keyInput = tokens[0];
                var keyValue = tokens[1];
                result[keyInput] = keyValue;
                tokens = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            var input = Console.ReadLine();

            unchanged = result.Where(x => x.Value != "null").OrderByDescending(x => x.Value.Length).ToDictionary(x => x.Key, x => x.Value);
            changed = result.Where(x => x.Value == "null").ToDictionary(x => x.Key, x => input);

            foreach (var kvp in changed)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
