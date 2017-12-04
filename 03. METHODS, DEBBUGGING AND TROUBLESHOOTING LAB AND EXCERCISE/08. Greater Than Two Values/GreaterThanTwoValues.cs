using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class GreaterThanTwoValues
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                var result = GetGreater(num1, num2);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                var char1 = char.Parse(Console.ReadLine());
                var char2 = char.Parse(Console.ReadLine());
               var result = GetGreater(char1, char2);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                var string1 = Console.ReadLine();
                var string2 = Console.ReadLine();
                var result =  GetGreater(string1, string2);
                Console.WriteLine(result);
            }
        }

        private static int GetGreater(int num1, int num2)
        {
            if (num1 > num2)
            { return num1; }
            else { return num2; }
        }

        private static char GetGreater(char char1, char char2)
        {
            if (char1 > char2)
            { return char1; }
            else { return char2; }
        }

        private static string GetGreater(string string1, string string2)
        {
            if (string1.CompareTo(string2) >= 0)
            { return string1;  }
            else
            { return string2;  }
        }
    }
}
