using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.SoftUni_Beer_Pong
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split('|').ToList();
            var storage = new Dictionary<string, Dictionary<string, int>>();
            var team = input[1];
            var player = input[0];
            var points = int.Parse(input[2]);
          
                while(input[0] != "stop")
            {
                 team = input[1];
                 player = input[0];
                 points =int.Parse(input[2]);

                if (!storage.ContainsKey(team))
                {
                    storage[team] = new Dictionary<string, int>();
                    storage[team][player] = points;
                }

                else
                {
                    if (!storage[team].ContainsKey(player))
                    {
                        if (storage[team].Count < 3)
                        { 
                            storage[team].Add(player,points);
                        }
                    }
                }
                        

                input = Console.ReadLine().Split('|',' ').ToList();
            }
            var filteredTeams = storage.Where(x => x.Value.Count == 3).OrderByDescending(x => x.Value.Sum(p => p.Value));

            int rang = 1;
            foreach (var kvp in filteredTeams)
            {
                var teamName = kvp.Key;
                Dictionary<string, int> playersData = kvp.Value;
                var sortedPlayersData = playersData.OrderByDescending(playerPoints => playerPoints.Value);
                Console.WriteLine($"{rang}. {teamName};");
                foreach (var playerPoints in sortedPlayersData)
                {
                    Console.WriteLine($"###{playerPoints.Key}: {playerPoints.Value}");
                }
            }

           
        }
    }
}
