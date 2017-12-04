using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _007.Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            var input = DateTime.ParseExact(date,"d-M-yyyy",CultureInfo.InvariantCulture);
            var dayOfWeek = input.DayOfWeek;
            Console.WriteLine(dayOfWeek);
        }
    }
}
