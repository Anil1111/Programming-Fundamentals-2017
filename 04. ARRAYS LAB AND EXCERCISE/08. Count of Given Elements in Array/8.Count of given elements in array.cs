using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Count_of_given_elements_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                { counter++; }
            }
            Console.WriteLine(counter);
        }
    }
}
