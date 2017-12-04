using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(n);
            Console.WriteLine(isPrime);
        }

        private static bool IsPrime(long n)
        {
            bool isPrime = false;
            if (n == 0 || n == 1)
            { return isPrime; }

            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                { return isPrime; }
            }
            return true;
        }
    }
}
