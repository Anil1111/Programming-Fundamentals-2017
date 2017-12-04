using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_of_negative_elements_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < 0)
                { counter++; }
            }

            Console.WriteLine(counter);

        }
    }
}
