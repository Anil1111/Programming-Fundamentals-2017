using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            Console.WriteLine(GetTriangleArea(w, h));
        }

        private static double GetTriangleArea(double w, double h)
        {
            var area = w * h / 2;
            return area;
        }
    }
}
