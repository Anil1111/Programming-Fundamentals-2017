using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009.String_and_Text_Proceeding
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reversed = input.Reverse().ToString(); ;
            Console.WriteLine(reversed);
        }
    }
}
