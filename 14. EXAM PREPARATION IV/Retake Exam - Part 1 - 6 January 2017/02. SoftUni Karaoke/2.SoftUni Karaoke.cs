using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var song = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, int> personAWARDCOUNT = new Dictionary<string, int>();
            Dictionary<string, List<string>> personAward = new Dictionary<string, List<string>>();

            var inputLine = Console.ReadLine();
            for (int i = 0; i < song.Count; i++)
            {
                song[i] = song[i].TrimStart();
            }

            while (inputLine != "dawn")
            {
                var tokens = inputLine.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var person = tokens[0].TrimStart();
                var performance = tokens[1].TrimStart();
                var award = tokens[2].TrimStart();

                if (participants.Contains(person) && song.Contains(performance))
                {
                    if (!personAWARDCOUNT.ContainsKey(person))
                    {
                        personAWARDCOUNT[person] = 1;
                        personAward[person] = new List<string>();
                        personAward[person].Add(award);
                    }
                    else
                    {
                        if (!personAward[person].Contains(award))
                        {
                            personAward[person].Add(award);
                            personAWARDCOUNT[person]++;
                        }
                        else
                        {
                            personAward[person].Add(award);
                        }
                    }

                }
                inputLine = Console.ReadLine();
            }
            foreach (var kvp in personAWARDCOUNT)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                foreach (var entry in personAward[kvp.Key].Distinct())
                {
                  {
                        Console.WriteLine($"--{entry}");
                        
                   }
                   
                }
            }
        }
    }
}

