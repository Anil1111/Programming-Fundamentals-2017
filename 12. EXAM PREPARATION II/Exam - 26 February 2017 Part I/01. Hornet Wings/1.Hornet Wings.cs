using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___26_February_2017_Part_I
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distanceFor1000Wings = long.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());
            
            var distanceMeters = (wingFlaps / 1000) * 5;
            var timeTravelSeconds = wingFlaps / 100;
            var rest = (wingFlaps / endurance) * 5;
            var total = timeTravelSeconds + rest;
            Console.WriteLine($"meter travel {timeTravelSeconds:f2} m.");
            Console.WriteLine($"{total} s.");
        }

    }
}
