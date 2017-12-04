using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var sum = 0.0;
            
              for (int i = 0; i < input.Count - 1; i++)
                {
                    if (input[i] == input[i + 1])
                    {
                        sum = input[i] + input[i + 1];
                        input[i + 1] = sum;
                        input.RemoveAt(i);
                         i = -1;

                    }
                }
            
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
