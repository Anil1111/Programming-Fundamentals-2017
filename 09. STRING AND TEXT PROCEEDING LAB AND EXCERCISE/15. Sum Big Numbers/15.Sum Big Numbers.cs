using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = Console.ReadLine().Trim();
            var string2 = Console.ReadLine().Trim();
            int maxLen = Math.Max(string1.Length, string2.Length);

            string result = string.Empty;
            var digitToBeAddedToResult = 0.0;
            var reminder = 0.0;
            bool isOverTens = false;
            

            for (int i = string1.Length-1; i >= 0; i--)
            {
                isOverTens = false;
                var digit1 = char.GetNumericValue(string1[i]);
                var digit2 = char.GetNumericValue(string2[i]);
                var sum = digit1 + digit2 + reminder;
                if(sum >= 10)
                {
                    isOverTens = true;
                     digitToBeAddedToResult = sum - 10;
                    if (reminder == 1)
                    {
                        reminder = 0;
                        reminder++;
                    }
                    else
                    {
                        reminder++;
                    }
                }
                else
                {
                    reminder = 0;
                }

                if (isOverTens == true)
                {
                     result = digitToBeAddedToResult + result;
                }
                else
                {
                    result = sum + result;
                }
                
              


            }
            if (isOverTens == true)
            { result = result.Insert(1,"0"); }
            Console.WriteLine(result);
        }
    }
}
