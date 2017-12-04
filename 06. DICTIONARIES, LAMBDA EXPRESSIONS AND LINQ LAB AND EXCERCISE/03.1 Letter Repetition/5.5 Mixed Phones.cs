using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = Console.ReadLine().Split(new[] {' ',':'},StringSplitOptions.RemoveEmptyEntries).ToList();
            var dict = new Dictionary<string, long>();

            while (true)
            {
                if (token[0] == "Over")
                {
                    foreach (var kvp in dict)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }

                    int number = 0;
                    bool isNumber = false;
                    isNumber = int.TryParse(token[0],out number);

                    if (isNumber == true)
                    {
                        dict[token[1]] = number;
                    }
                    else
                    {
                        dict[token[0]] = Convert.ToInt64(token[1]);
                    }
                token = Console.ReadLine().Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();


            }
            }
        }
    }

