using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
            {
            var number = int.Parse(Console.ReadLine());
            var result = Fibonacci(number);
            Console.WriteLine(result);

            
        }

        private static int Fibonacci(int number)
        {
            var a = 1;
            var b = 1;
            for (int i = 1; i <= number; i++)
            {
                var oldA = a;
                a = b;
                b = oldA + b;
            }
            return a;
            


        }
    }
}
