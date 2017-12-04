using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            bool isSymmetric = true;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    isSymmetric = false;
                    break;
                }
            }

            if (isSymmetric == true)
            { Console.WriteLine("yes"); }
            else
            { Console.WriteLine("no"); }
        }
    }
}
