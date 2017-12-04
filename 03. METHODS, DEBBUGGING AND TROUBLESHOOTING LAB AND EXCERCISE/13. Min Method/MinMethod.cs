using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            var int1 = int.Parse(Console.ReadLine());
            var int2 = int.Parse(Console.ReadLine());
            var int3 = int.Parse(Console.ReadLine());

            if (int1 < int2)
            {
               if  (int1 < int3)
                 {
                    var reuslt = GetMax(int2, int3);
                    Console.WriteLine(reuslt);
                 }
                
            }
            if (int2 < int1)
            {
                if (int2 < int3)
                {
                   
                    var result = GetMax(int1, int3);
                    Console.WriteLine(result);
                }
            }
            if(int3 < int1)
            {
                if (int3 < int2)
                {
                   var result = GetMax(int1, int2);
                    Console.WriteLine(result);
                }
            }
        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            { return a; }
            else { return b; }
        }
    }
}
