using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class MathPower
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());

           var result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, double power)
        {
            var result = Math.Pow(number, power);
            return result;
        }
    }
}
