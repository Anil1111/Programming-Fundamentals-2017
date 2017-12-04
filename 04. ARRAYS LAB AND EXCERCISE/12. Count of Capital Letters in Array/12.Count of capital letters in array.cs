using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_of_capital_letters_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            var counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == 1)
                {
                    char letterToChar = Convert.ToChar(array[i]);
                    if ( letterToChar >= 65 && letterToChar <= 90)
                    { counter++; }
                }

            }
            Console.WriteLine(counter);

        }
    }
}
