using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Spy
{
    public string Name { get; set; }
    public int DaysInService { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        var inputLine = Console.ReadLine();
        Dictionary<string, List<Spy>> dataBase = new Dictionary<string, List<Spy>>();


        while (inputLine != "quit")
        {
            var tokens = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var country = tokens[0];
            var spyName = tokens[1];
            var spyDays = int.Parse(tokens[2]);

            if (!dataBase.ContainsKey(country))
            {
                dataBase[country] = new List<Spy>();
                Spy currentSpy = new Spy
                {
                    Name = spyName,
                    DaysInService = spyDays
                };
                dataBase[country].Add(currentSpy);
            }
            if (!dataBase[country].Any(x => x.Name == spyName))
            {
                dataBase[country].Add(new Spy {Name = spyName,DaysInService = spyDays });
            }
            var indexS = dataBase[country].FindIndex(x => x.Name == spyName);
            dataBase[country][indexS].DaysInService = spyDays;

            inputLine = Console.ReadLine();
        }
        Console.WriteLine();

        foreach (var entry in dataBase.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"Country: {entry.Key}");
            foreach (var spy in dataBase[entry.Key].OrderByDescending(x => x.DaysInService))
            {
                Console.WriteLine($"**{spy.Name} : {spy.DaysInService}");
            }
        }
    }
}
