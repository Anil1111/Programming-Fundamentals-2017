using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FlipListSlides
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var firstElement = input[0];
            var lastelement = input[input.Count-1];

            for (int i = 1; i < input.Count/2; i++)
            {
                var tempElement = input[i];
                input[i] = input[input.Count -1 -i];
                input[input.Count -1 - i] = tempElement;
            }
         

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
