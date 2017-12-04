using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Unicode_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            string result = string.Empty;
            List<string> finalResult = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                result = string.Empty;
                var currentChar =Convert.ToInt32(input[i]);
                while (currentChar > 0 )
                {
                    var remainder = currentChar % 16;
                    currentChar /=16;
                    var remainderToString = Convert.ToString(remainder);
                    result = remainderToString + result;
                }
                finalResult.Add(result);

            }
            foreach (var item in finalResult)
            {
                Console.WriteLine($"\\u00{item}");
            }
            // the fast way -> Console.WriteLine($"\\u{letter:x}"); way, to format letter in hexadecimal;

        }
    }
}
