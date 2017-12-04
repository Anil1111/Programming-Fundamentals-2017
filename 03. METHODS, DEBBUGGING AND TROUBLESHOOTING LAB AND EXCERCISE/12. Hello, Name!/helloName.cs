using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class helloName
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
           var result = HelloName(name);
            Console.WriteLine(result);
        }

        private static string HelloName(string name)
        {
            var result = $"Hello, {name}!";
            return result;
        }
    }
}
