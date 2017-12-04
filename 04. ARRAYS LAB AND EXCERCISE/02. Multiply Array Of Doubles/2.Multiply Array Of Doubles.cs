using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Multiply_Array_Of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double smallestItem = double.MaxValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < smallestItem)
                { smallestItem = input[i]; }
            }
            Console.WriteLine(smallestItem);
        }
    }
}
