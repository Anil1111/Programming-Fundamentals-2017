using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extended_Retake_Exam___09_May_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            var capacityFuel = double.Parse(Console.ReadLine());
            var heavyWindsMiles = double.Parse(Console.ReadLine());

            var nonHeavyWindTravel = distance - heavyWindsMiles;
            var nonHeavyWinDCOnsumption = nonHeavyWindTravel * 25;
            var heavyWIndConsumption = heavyWindsMiles * (25 * 1.5);
            var totalConsumption = nonHeavyWinDCOnsumption + heavyWIndConsumption;
            var tolerance = totalConsumption * 0.05;
            var totalFuel = tolerance + totalConsumption;

            if (capacityFuel >= totalFuel)
            {
                Console.WriteLine($"Fuel Needed: {totalFuel:f2}L.");
                Console.WriteLine($"Enough with {(capacityFuel-totalFuel):f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {(totalFuel-capacityFuel):f2}L more");
            }
            
                

        }
    }
}
