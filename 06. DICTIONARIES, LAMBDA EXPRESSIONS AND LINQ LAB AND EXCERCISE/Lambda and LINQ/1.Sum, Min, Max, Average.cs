using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_and_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                array[i] = num; 
            }
            Console.WriteLine($"Sum = {array.Sum()}");
            Console.WriteLine($"Min = {array.Min()}");
            Console.WriteLine($"Max = {array.Max()}");
            Console.WriteLine($"Average = {array.Average()}");
        }
    }
}
