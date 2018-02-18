using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < sequence.Count; i++)
            {
                counter++;
                if (sequence[i] == 0)
                {
                    continue;
                }
                else
                {
                    var currentValue = sequence[i];
                    sequence[i] = 0;
                    i = currentValue - 1;
                    counter--;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
