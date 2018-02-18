using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Extended__Exam___30_April_2017_Part_I
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine())*100;
            var width = double.Parse(Console.ReadLine());

            var reminder = length % width;

            if (reminder != 0)
            {
               var percentaage = (length / width) * 100;
                Console.WriteLine($"{percentaage:f2}");
            }
            else
            {
                var product = (int)(length * width);
                Console.WriteLine($"{product:f2}%");
            }



        }
    }
}
