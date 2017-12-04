using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class MultiplyEvenOdds
    {
        static void Main(string[] args)
        {
            var n = Math.Abs( int.Parse(Console.ReadLine()));

           var result = GetMupltiplyOfEvenAndOdds(n);
            Console.WriteLine(result);
        }

        private static int GetMupltiplyOfEvenAndOdds(int n)
        {
            int sumEvens = GetSumOfEvensDigits(n);
            int sumOdd = GetSumOfOddDigits(n);
            return sumEvens * sumOdd;
        }

        private static int GetSumOfOddDigits(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvensDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
