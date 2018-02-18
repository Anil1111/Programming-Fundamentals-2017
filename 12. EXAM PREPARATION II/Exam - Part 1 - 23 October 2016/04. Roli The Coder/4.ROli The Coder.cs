using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> idEvents = new SortedDictionary<int, string>();
            SortedDictionary<string, List<string>> eventParticipators = new SortedDictionary<string, List<string>>();

            var inputLine = Console.ReadLine();

            while (inputLine!="Time for Code")
            {
                if (!inputLine.Contains("#"))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                else
                {
                    var tokens = inputLine.Split(new char[] {'#',' '},StringSplitOptions.RemoveEmptyEntries).ToList();
                    var id = int.Parse(tokens[0]);
                    var eVent = tokens[1];
                    List<string> participators  = new List<string>();
                    for (int i = 2; i < tokens.Count; i++)
                    {
                        participators.Add(tokens[i]);
                    }

                    if (!idEvents.ContainsKey(id))
                    {
                        idEvents.Add(id, eVent);
                        eventParticipators[eVent] = new List<string>();
                        eventParticipators[eVent].AddRange(participators);
                        
                    }
                    else
                    {
                        if (idEvents[id].Contains(eVent))
                        {
                            for (int i = 0; i < participators.Count; i++)
                            {
                                var currentPerson = participators[i];
                                if (!eventParticipators[eVent].Contains(currentPerson))
                                {
                                    eventParticipators[eVent].Add(currentPerson);
                                }

                            }
                        }
                    }

                    
                }
                inputLine = Console.ReadLine();


            }

            foreach (var item in eventParticipators)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Count}");
                foreach (var person in item.Value)
                {
                    Console.WriteLine($"{person}");
                }
            }
        }
    }
}
 