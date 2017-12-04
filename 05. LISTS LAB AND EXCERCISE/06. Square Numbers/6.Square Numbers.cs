using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).OrderByDescending(a => a).ToList();
            var squareNumbers = new List<double>();

            for (int i = 0; i < input.Count; i++)
            {
                var num = input[i];
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                { squareNumbers.Add(num); }
            }
            Console.WriteLine(string.Join(" ",squareNumbers));
        }
    }
}
