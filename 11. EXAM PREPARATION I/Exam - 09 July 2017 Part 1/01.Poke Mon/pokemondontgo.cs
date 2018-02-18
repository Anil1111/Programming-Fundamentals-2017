using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___09_July_2017_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var halfvalue = (double)N /2;
            var M = int.Parse(Console.ReadLine());
            var Y = int.Parse(Console.ReadLine());
            var counter = 0;

            while (N = M)
            {
                if (N == halfvalue)
                {
                    N /= Y;
                    if (N < M)
                    {
                        break;
                    }
                }
                N -= M;
                counter++;
                

            }
            Console.WriteLine();
            Console.WriteLine(N);
            Console.WriteLine(counter);
        }
    }
}
