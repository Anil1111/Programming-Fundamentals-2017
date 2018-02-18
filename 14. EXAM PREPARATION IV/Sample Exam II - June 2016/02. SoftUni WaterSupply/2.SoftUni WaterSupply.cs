using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SOftUni_WaterSupply
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfWater = int.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var capacity = int.Parse(Console.ReadLine());
            var waterInBottles = bottles.Sum();
            var waterNeeded = waterInBottles - (bottles.Count * capacity);

            if (waterNeeded < amountOfWater)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {amountOfWater - waterNeeded}");

            }
            else
            {
                Console.WriteLine("We need more water!");
                if (amountOfWater % 2 == 0)
                {
                    for (int i = 0; i < bottles.Count; i++)
                    {
                        var currentBottle = bottles[i];
                        int emptybottles = 0;
                        List<int> listOfIndexes = new List<int>();
                        var neededForNextBottle = capacity - currentBottle;
                        amountOfWater -= neededForNextBottle;
                        if (amountOfWater < 0)
                        {
                            emptybottles++;
                            listOfIndexes.Add(1);
                        }
                    }
                }
                else
                {
                    for (int i = bottles.Count; i > 0; i++)
                    {
                        var currentBottle = bottles[i];
                        int emptybottles = 0;
                        List<int> listOfIndexes = new List<int>();
                        var neededForNextBottle = capacity - currentBottle;
                        amountOfWater -= neededForNextBottle;
                        if (amountOfWater < 0)
                        {
                            emptybottles++;
                            listOfIndexes.Add(i);
                        }
                    }
                }
               
            }


        }
    }
}
