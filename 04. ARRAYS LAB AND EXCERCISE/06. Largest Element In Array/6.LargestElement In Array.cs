using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Largest_Element_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int biggestNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > biggestNum)
                { biggestNum = array[i]; }
            }

            Console.WriteLine(biggestNum);

        }
    }
}
