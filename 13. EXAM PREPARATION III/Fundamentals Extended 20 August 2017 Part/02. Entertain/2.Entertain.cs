using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Entertain
{
    class Program
    {
        static void Main(string[] args)
        {
            var power = int.Parse(Console.ReadLine());
            List<int> wagons = new List<int>();
            var inputLine = Console.ReadLine();

            while (inputLine !="All ofboard!")
            {
                var currentWagoon = int.Parse(inputLine);
                if(wagons.Count == 0)
                {
                    wagons.Add(currentWagoon);
                }
                else
                {
                    wagons.Add(currentWagoon);
                    var totalPowerWagoons = wagons.Sum();
                    if (totalPowerWagoons > power)
                    {
                        var average = wagons.Average();
                        var closest = wagons.OrderBy(x => Math.Abs(average - x)).First();
                        wagons.Remove(closest);
                    }
                   
                }

                 inputLine = Console.ReadLine();
            }
            wagons.Reverse();
            Console.WriteLine(string.Join(", ",wagons) +" "+ power);
        }
    }
}
