using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4.Winning_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            string regex = @"([(#^$@){6,}]+)";

            for (int i = 0; i < input.Count; i++)
            {
                var ticket = input[i];
                if (ticket.Length >= 20)
                {
                    MatchCollection match = Regex.Matches(ticket,regex);
                    List<string> specialSymbols = new List<string>();

                    foreach (Match item in match)
                    {
                        specialSymbols.Add(item.Value);
                    }

                    if (specialSymbols.Count == 0)
                    {
                        Console.WriteLine("No match");
                    }
                    else if (specialSymbols.Count == 1)
                    {
                        if (specialSymbols[0].Length >= 20)
                        {
                            Console.WriteLine($"ticket {ticket} - {specialSymbols[0].Length / 2}$ Jackpot! ");
                        }
                    }
                    else if (specialSymbols.Count >= 2)
                    {
                        if (specialSymbols[0].Length >= 6 && specialSymbols[0].Length < 9
                            && specialSymbols[1].Length >= 6 && specialSymbols[0].Length < 9)
                        {
                            Console.WriteLine($"ticket {ticket} - {specialSymbols[0].Length}$ ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ticket");
                    continue;
                }
            }
        }
    }
}
