using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.ListsT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> nonNegative = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > 0)
                { nonNegative.Add(input[i]); }
            }
            Console.WriteLine(string.Join(" ",nonNegative));

        }
    }
}
