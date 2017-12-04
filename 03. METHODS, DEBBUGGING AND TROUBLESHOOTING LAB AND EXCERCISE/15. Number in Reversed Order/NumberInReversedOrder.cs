using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class NumberInReversedOrder
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            var text = ReverseString(number);
            foreach (var item in text)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        private static Array ReverseString(string number)
        {
            char[] txt = number.ToArray();
            Array.Reverse(txt);
            return txt;

        }
    }
}
;