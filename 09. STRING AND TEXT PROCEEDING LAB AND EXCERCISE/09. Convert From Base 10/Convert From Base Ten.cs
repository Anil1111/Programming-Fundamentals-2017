using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ConvertFromBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); 
            var baSe =input[0];
            var number = input[1];
            string digit = string.Empty;

            while (number > 0)
            {
                var reminder = number % baSe;
                number = number / baSe;
                digit = Convert.ToString(reminder) + digit;

            }
            Console.WriteLine(digit);
        }
    }
}
