using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var realNumbs =  Console.ReadLine().Split().Select(double.Parse).ToList();
            realNumbs = realNumbs.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ",realNumbs));

        }
    }
}
