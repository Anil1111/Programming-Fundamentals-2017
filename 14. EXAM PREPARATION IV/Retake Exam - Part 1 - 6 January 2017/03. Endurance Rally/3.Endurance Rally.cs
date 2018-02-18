using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < inputLine.Count; i++)
            {
                var name = inputLine[0];
                var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                var checkPoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                var fuel = (double)name[0];
                var isFinished = false;

                var lastZone = 0;
                for (int k = 0; k < zones.Count; k++)
                {
                    double zone = zones[k];


                    if (checkPoints.Contains(k))
                    {
                        fuel += zone;
                    }
                    else
                    {
                        fuel -= zone;

                        if (fuel <= 0)
                        {
                            lastZone = k;
                            break;
                        }
                    }

                    if (fuel > 0)
                    {
                        Console.WriteLine($"{name} - fuel left {fuel:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{name} - reached {fuel}");
                    }

                }
            }
        }
    }
}



