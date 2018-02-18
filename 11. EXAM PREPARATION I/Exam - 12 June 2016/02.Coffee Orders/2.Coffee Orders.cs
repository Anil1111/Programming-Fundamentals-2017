using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
     

namespace _2.Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var total = 0.0;

            for (int i = 0; i < n; i++)
            {
                double price = double.Parse(Console.ReadLine());
                string date = Console.ReadLine();
                var currentDate = DateTime.ParseExact(date,"d/M/yyyy",CultureInfo.InvariantCulture);
                var capsules = double.Parse(Console.ReadLine());
                var monthDuration = DateTime.DaysInMonth(currentDate.Year,currentDate.Month);
                var result = (monthDuration * capsules) * price;
                Console.WriteLine($"The price of the coffee is: ${result:f2}");
                total += result;

            }
            Console.WriteLine($"Total {total:f2}");
            
        }
    }
}
