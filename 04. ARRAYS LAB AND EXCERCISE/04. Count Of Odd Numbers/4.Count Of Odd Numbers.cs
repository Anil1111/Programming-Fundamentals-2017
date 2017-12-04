using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Count_Of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                { sum++; }
            }
            Console.WriteLine(sum);
        }
    }
}
