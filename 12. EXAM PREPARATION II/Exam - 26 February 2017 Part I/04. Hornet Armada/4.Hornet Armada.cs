using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class Soldier
{
    public string Type { get; set; }
    public int Count { get; set; } = 0;
}
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        Dictionary<string, int> activityLegion = new Dictionary<string, int>();
        Dictionary<string, List<Soldier>> legionSoldiers = new Dictionary<string, List<Soldier>>();


        for (int i = 0; i < n; i++)
        {
            var inputLine = Console.ReadLine().Split(new string[] { " = ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var lastAcivity = int.Parse(inputLine[0]);
            var legionName = inputLine[1];
            var soldierTokens = inputLine[2].Split(':').ToList();
            var soldierType = soldierTokens[0];
            var soldierCount = int.Parse(soldierTokens[1]);

            if (!activityLegion.ContainsKey(legionName))
            {
                activityLegion[legionName] = lastAcivity;
                legionSoldiers[legionName] = new List<Soldier>();
                Soldier currentSoldier = new Soldier
                {
                    Type = soldierType,
                    Count = soldierCount
                };
                legionSoldiers[legionName].Add(currentSoldier);

            }
            else
            {
                if (activityLegion[legionName] < lastAcivity)
                {
                    activityLegion[legionName] = lastAcivity;
                }
                if (!legionSoldiers[legionName].Any(x => x.Type == soldierType))
                {
                    legionSoldiers[legionName].Add(new Soldier { Type = soldierType, Count = soldierCount });
                }
                else
                {
                    var indexS = legionSoldiers[legionName].FindIndex(x => x.Type == soldierType);
                    legionSoldiers[legionName][indexS].Count = soldierCount;
                }

            }



        }
        Console.WriteLine();
        var input = Console.ReadLine();

        
        if (input.Contains("\\"))
        {
            var tokens = input.Split('\\').ToList();
            foreach (var sol in legionSoldiers)
            {
                if (sol.Key == tokens[1])
                {
                    Console.Write($"{sol.Key} -> ");
                    foreach (var entry in sol.Value)
                    {
                        Console.Write($"{entry.Count}");
                    }
                    Console.WriteLine();
                }
            }
        }
        else
        {
            foreach (var legion in activityLegion.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{legion.Value} : {legion.Key}");
            }
        }
    }
}


