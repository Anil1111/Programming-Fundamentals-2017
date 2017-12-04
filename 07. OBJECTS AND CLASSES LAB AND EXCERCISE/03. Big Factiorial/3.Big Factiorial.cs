using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.Big_Factiorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            BigInteger n = 1;
            for (int i = 1; i <= num; i++)
            {
                n = n * i;
            }
            Console.WriteLine(n);
            
        }
    }
}
