using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Odd_Num_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

          

            for (int i = 1; i < input.Length; i++)
            {
                if (i % 2 != 0 && input[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} - > {input[i]}");
                }
            }
        }
    }
}
