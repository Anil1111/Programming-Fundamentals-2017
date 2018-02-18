using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Retake_Exam___Part_1___6_January_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine();
            var leavingTime = DateTime.ParseExact(time,"HH:mm:ss",CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine())%86400;
            var stepPerSecond = int.Parse(Console.ReadLine())%86400;
            
            var arrival = steps * stepPerSecond;
            DateTime arrivalTime = leavingTime.AddMinutes(arrival);
        //    Console.WriteLine("Time Arrival: {0}", Arrival.ToString("HH:mm:ss"));
        }
    }
}
