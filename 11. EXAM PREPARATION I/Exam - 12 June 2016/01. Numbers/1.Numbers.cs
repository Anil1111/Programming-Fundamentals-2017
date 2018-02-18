using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___12_June_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var average = input.Average();

            var ordered = input.OrderByDescending(x => x).Take(5).Where(x => x > average).ToList();

            if (ordered.Count <= 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(", ", ordered));
            }
            
           
        }
    }
}
