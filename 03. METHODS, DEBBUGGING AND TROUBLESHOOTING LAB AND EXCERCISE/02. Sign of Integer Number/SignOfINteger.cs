using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SignOfINteger
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        private static void PrintSign(int n)
        {
            if (n > 0)
            { Console.WriteLine($"The number {n} is positive."); }
            else if (n < 0)
            { Console.WriteLine($"The number {n} is negative."); }
            else if (n == 0)
            { Console.WriteLine($"The number {n} is zero."); }

        }
    }
}
