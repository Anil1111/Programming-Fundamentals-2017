using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Simple_Array_Proccessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
                sum += sequence[i];
            }
            Console.WriteLine(sum);


        }
    }
}
