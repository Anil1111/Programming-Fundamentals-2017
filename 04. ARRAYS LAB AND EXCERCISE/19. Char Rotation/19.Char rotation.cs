using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Char_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToArray();
            int[] digits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char value;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 == 0)
                {  value = Convert.ToChar(Math.Abs( digits[i] - Convert.ToInt32(text[i]))); }
                else
                {  value = Convert.ToChar(Math.Abs( digits[i] + Convert.ToInt32(text[i]))); }
                Console.Write(Convert.ToChar(value));
            }
            Console.WriteLine();
        }
    }
}
