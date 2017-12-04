using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class PrimeCheckerInRange
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
           
            List<int> result = PrimeNumbers(start, end);
            foreach (var item in result)
            {
                Console.Write(item + ", ");
            }
            
        }

        private static List<int> PrimeNumbers(int start,int end)
        {
            bool isPrime = true;
            var result = new List<int>();

            for (int i = start ; i <= end; i++)
            {
                if (i < 2)
                {
                    isPrime = false;
                }

                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {  isPrime = false; break; }
                    
                }
                if (isPrime)
                { result.Add(i); }

            }
            return result;
            
            
        }
    }
}
