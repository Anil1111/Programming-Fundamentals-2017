using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Increasing_Sequence_of_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIncreasing = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                { isIncreasing = false; }
            }

            if (isIncreasing == true)
            { Console.WriteLine("Yes"); }
            else
            { Console.WriteLine("No"); }
        }
    }
}
