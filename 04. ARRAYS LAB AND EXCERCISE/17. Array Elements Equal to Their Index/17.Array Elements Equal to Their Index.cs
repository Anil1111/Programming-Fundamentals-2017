using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> result = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == i)
                { result.Add(input[i]); }
            }

            Console.WriteLine(string.Join(" ",result));
        }

    }
}
