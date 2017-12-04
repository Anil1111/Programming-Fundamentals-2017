using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Mixed_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = new SortedDictionary<string, long>();

            while (true)
            {
                if (tokens[0] == "Over") { break; }
                int number;
                bool isNumber = false;

                isNumber = int.TryParse(tokens[0],out number);

                if (isNumber == true)
                {
                    result[tokens[1]] = number;
                }
                else
                {
                    result[tokens[0]] = Convert.ToInt64(tokens[1]);
                }
                tokens = Console.ReadLine().Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            }
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
    
}
