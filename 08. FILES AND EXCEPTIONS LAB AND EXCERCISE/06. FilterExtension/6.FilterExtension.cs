using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.FilterExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"D:\Daisy_Files\Desktop\input");
            var txtOnly = files.Where(x => x.Contains(".txt")).ToArray();
            Console.WriteLine(string.Join(" ",txtOnly));

        }
    }
}
