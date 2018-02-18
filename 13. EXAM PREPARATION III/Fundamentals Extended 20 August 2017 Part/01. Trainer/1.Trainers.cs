using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_Extended_20_August_2017_Part
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var technicalTeam = 0.0;
            var theoreticalTeam = 0.0;
            var practicalTeam = 0.0;
            Dictionary<string, long> result = new Dictionary<string, long>();
            

            for (int i = 0; i < n; i++)
            {
                var distance = double.Parse(Console.ReadLine()) * 1600;
                var cargo = double.Parse(Console.ReadLine()) * 1000;
                var team = Console.ReadLine();
                var participantEarnedMOney = (cargo * 1.5) - (0.7 * distance * 2.5);

                if (!result.ContainsKey(team))
                {
                    result[team] = 0;
                }


                if (team == "Technical")
                {
                    technicalTeam += participantEarnedMOney;
                    result[team] = (long)technicalTeam;
                    
                }
                if (team == "Theoretical")
                {
                    theoreticalTeam += participantEarnedMOney;
                    result[team] =(long) theoreticalTeam;


               }
                if (team == "Practical")
                {
                    practicalTeam += participantEarnedMOney;
                    result[team] =(long) practicalTeam;
                }

             }
            var mostEarnedMoney = result.OrderByDescending(x => x.Value).Take(1);
            foreach (var item in mostEarnedMoney)
            {
                Console.WriteLine($"The {item.Key} Trainers win with ${item.Value:f3}.");
            }

        }
    }
}
