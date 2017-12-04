using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = Console.ReadLine().Split().ToList();
            var dict = new SortedDictionary<string, string>();

            while (true)
            {
                if (token[0] == "ListAll")
                {
                    foreach (var kvp in dict)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
                if (token[0] == "END")
                { break; }

                if (token[0] == "A")
                {
                    dict[token[1]] = token[2];
                }

                if (token[0] == "S")
                {
                    bool contains = false;
                    foreach (var enrty in dict)
                    {
                        if (dict.ContainsKey(token[1]))
                        {
                            contains = true;
                            var number = enrty.Value;
                            { Console.WriteLine($"{enrty.Key} -> {enrty.Value}"); }
                        }
                    }

                    if (contains == false)
                    {
                        Console.WriteLine($"Contact {token[1]} does not exist.");
                    }
                }


                token = Console.ReadLine().Split().ToList();
            }
        }
    }
}
