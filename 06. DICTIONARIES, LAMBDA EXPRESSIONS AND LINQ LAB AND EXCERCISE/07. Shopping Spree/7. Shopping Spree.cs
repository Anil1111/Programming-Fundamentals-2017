using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var tokens = Console.ReadLine().Split().ToList();
            var storage = new Dictionary<string, double>();

            while (tokens[0] != "end")
            {
                var product = tokens[0];
                var itsPrice = double.Parse(tokens[1]);

                if (storage.ContainsKey(product))
                {
                    if (storage[product] > itsPrice)
                    {
                        storage[product] = itsPrice;
                    }
                }
                else
                { storage[product] = itsPrice; }

                    tokens = Console.ReadLine().Split().ToList();
                
            }
            var totalSum = storage.Sum(x => x.Value);
            if (totalSum > budget)
            { Console.WriteLine("Need more money... Just buy banichka"); }
            else
            {
                var toBePrinted = storage.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length).ToDictionary(x => x.Key,x => x.Value);
                foreach (var kvp in toBePrinted)
                {
                    Console.WriteLine($"{kvp.Key} costs {kvp.Value}");
                }
            }
        }
    }
}
