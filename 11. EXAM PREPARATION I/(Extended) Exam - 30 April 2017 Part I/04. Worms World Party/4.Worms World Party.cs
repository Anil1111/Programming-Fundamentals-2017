using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Worm
{
    public string Name { get; set; }
    public int Score { get; set; } = 0;
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<Worm>> WormsWorldParty = new Dictionary<string, List<Worm>>();
        var input = Console.ReadLine();

        while (input != "quit")
        {
            var tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var wormName = tokens[0];
            var teamName = tokens[1];
            var wormScore = int.Parse(tokens[2]);

            if (!WormsWorldParty.ContainsKey(teamName))
            {
                WormsWorldParty[teamName] = new List<Worm>();
                Worm currentWorm = new Worm
                {
                    Name = wormName,
                    Score = wormScore
                };
            }
            if (WormsWorldParty[teamName].Any(x => x.Name == wormName))
            {
                input = Console.ReadLine();
                continue;
            }
            if (!WormsWorldParty[teamName].Any(x => x.Name == wormName))
            {
                WormsWorldParty[teamName].Add(new Worm {Name = wormName,Score = wormScore });
            }

            input = Console.ReadLine();
        }
        Console.WriteLine();

        WormsWorldParty = WormsWorldParty.OrderByDescending(x => x.Value.Sum(s => s.Score))
            .ThenByDescending(x => x.Value.Sum(y => y.Score) / x.Value.Count())
            .ToDictionary(x => x.Key, x => x.Value);

        var counter = 1;
        foreach (var entry in WormsWorldParty)
        {
            Console.WriteLine($"{counter}. {entry.Key} - {entry.Value.Sum(x => x.Score)}");
            foreach (var score in entry.Value)
            {
                Console.WriteLine($"###{score.Name} : {score.Score}");
            }
            counter++;
        }
    }
}

