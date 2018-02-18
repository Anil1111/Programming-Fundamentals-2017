using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Exam_II___June_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<int> profit = new List<int>();
            var income = 0;
            var expenses = 0;
            var profitOverall = 0;

            for (int i = 0; i < n; i++)
            {
                var adultCounts = int.Parse(Console.ReadLine());
                var adultTicketPrice = int.Parse(Console.ReadLine());
                var youthCount = int.Parse(Console.ReadLine());
                var youthTicketPrice = int.Parse(Console.ReadLine());
                var fuelPriceHour = int.Parse(Console.ReadLine());
                var fuelCOnsumptionHour = int.Parse(Console.ReadLine());
                var fuelDuration = int.Parse(Console.ReadLine());

                income = (adultCounts * adultTicketPrice) + (youthCount * youthTicketPrice);
                expenses = (fuelCOnsumptionHour * fuelPriceHour * fuelDuration);
                 profitOverall = income - expenses;
                    profit.Add(income- expenses);

                if (profitOverall > 0)
                {
                    
                    Console.WriteLine($"You are ahead with {profitOverall:f3}.$ ");
                }


                if (profitOverall < 0)
                {
                    
                    Console.WriteLine($"We’ve got to sell more tickets! We’ve lost {(profitOverall):f3}$.");
                }

             }
            Console.WriteLine($"Overall profit -> {profit.Sum():f3}$");
            Console.WriteLine($"Average profit -> {(profit.Sum()/n ):f3}$");
        }
    }
}
