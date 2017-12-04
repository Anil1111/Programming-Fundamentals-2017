using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Multiply_Big_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var longNum = Console.ReadLine();
            var shortNum =int.Parse(Console.ReadLine());
            var LongNumReversed = longNum.Reverse();
            var result = string.Empty;
            var reminder = 0;
            
            foreach (var item in LongNumReversed)
            {
                
                var longDIg = char.GetNumericValue(item);
                double sum = longDIg * shortNum + reminder;
                result = (sum % 10) + result;
                if (sum > 9)
                {
                    reminder = (int)sum /10;
                }
                else { reminder = 0; }

            }
            if(reminder != 0)
            { result = reminder + result; }
            
            Console.WriteLine(result);
        }
    }
}
