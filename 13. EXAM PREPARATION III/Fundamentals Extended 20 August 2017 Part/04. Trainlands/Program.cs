using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Wagoon
{
    public string Name { get; set; }
    public int Power { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<Wagoon>> dataBase = new Dictionary<string, List<Wagoon>>();
        List<string> trainsListName = new List<string>();

        var inputLine = Console.ReadLine();
        while (inputLine != "It's Training Men!")
        {
            if (inputLine.Contains("="))
            {
                var tokensS = inputLine.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var secondTrain = tokensS[1];
                if (!dataBase.ContainsKey(tokensS[0]))
                {
                    dataBase[tokensS[0]] = new List<Wagoon>();
                }
                foreach (var wagoon in dataBase[secondTrain])
                {
                    var currentWagoon = new Wagoon { Name = wagoon.Name, Power = wagoon.Power };
                    dataBase[tokensS[0]].Add(currentWagoon);
                }


                inputLine = Console.ReadLine();
                continue;
            }
            var tokens = inputLine.Split(new string[] { " -> "}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var train = tokens[0];

            trainsListName.Add(train);


            if (!trainsListName.Contains(tokens[1]))
            {
                var wagoonInput = tokens[1].Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Wagoon currentWagoon = new Wagoon
                {
                    Name = wagoonInput[0],
                    Power = int.Parse(wagoonInput[1])
                };
                if (!dataBase.ContainsKey(train))
                {
                    dataBase[train] = new List<Wagoon>();
                    dataBase[train].Add(currentWagoon);
                }
                else
                {
                    if (!dataBase[train].Any(x => x.Name == currentWagoon.Name))
                    {
                        dataBase[train].Add(currentWagoon);
                    }
                }
                
            }
            else
            {
                var secondTrain = tokens[1];
                if (!dataBase.ContainsKey(train))
                {
                    dataBase[train] = new List<Wagoon>();
                }
                foreach (var wagoon in dataBase[secondTrain])
                {
                    var currentWagoon = new Wagoon { Name = wagoon.Name, Power = wagoon.Power };
                    dataBase[train].Add(currentWagoon);
                }


                dataBase.Remove(secondTrain);

                

            }
            

            inputLine = Console.ReadLine();
        }

        Console.WriteLine();
        foreach (var entry in dataBase.OrderByDescending(x => x.Value.Count()))
        {
            Console.WriteLine($"Train {entry.Key}");
            foreach (var item in dataBase[entry.Key].OrderByDescending(x => x.Power))
            {
                Console.WriteLine($"###{item.Name} - {item.Power}");
            }
            
        }
    }
}
