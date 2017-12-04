using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CamelsBack
{
    class Program
    {
        static void Main(string[] args)
        {
            var buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var camelsBack = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isStabilized = false;

            while (isStabilized != true)
            {
                
                if (buildings.Count == camelsBack)
                {
                    isStabilized = true;
                    break;
                }

                buildings.RemoveAt(0);
                buildings.RemoveAt(buildings.Count - 1);
                counter++;
                
            }
            Console.WriteLine(counter);
        }
    }
}
