using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool areTheSame = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    areTheSame = false;
                    break;
                }
            }

            if (areTheSame == true)
            { Console.WriteLine("Yes"); }
            else
            { Console.WriteLine("no"); }
        }
    }
}
