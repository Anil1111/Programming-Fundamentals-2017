using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var hornets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var hornetsPower = hornets.Sum();
            for (int i = 0; i < beehives.Count; i++)
            {
                var currentBee = beehives[i];
                if (hornetsPower > currentBee)
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else
                {
                    beehives[i] -= hornetsPower;
                    var firstHornet = hornets.First();
                    hornets.Remove(firstHornet);
                    hornetsPower = hornets.Sum();
                }

                
            }
            if (beehives.All(x => x == 0 ))
            {
                Console.WriteLine(string.Join(", ", hornets));
            }
            else
            {
                Console.WriteLine(string.Join(", ", beehives));
            }
        }
    }
}
