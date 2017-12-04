using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Rotate_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            var rotated = new List<string>(input.Length);
            
            for (int i = 0; i < input.Length - 1 ; i++)
            {
                rotated.Add(input[i]);
            }
            var lastElement = input[input.Length - 1];
            rotated.Insert(0, lastElement);


            Console.WriteLine(string.Join(" ",rotated));
        }
    }
}
