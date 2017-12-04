using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Integer_Insertation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string inputLine = Console.ReadLine();


            while (inputLine != "end")
            {
                var currentNumber = Convert.ToInt32(inputLine);
                var firstDigit = 0;
                while (currentNumber > 0)
                {
                    firstDigit = currentNumber % 10;
                    currentNumber /= 10;
                }
                currentNumber = Convert.ToInt32(inputLine);
                input.Insert(firstDigit,currentNumber);

                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
