using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files__Directories_and_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"D:\Daisy_Files\Desktop\text files\text.txt");
            var oddLines = lines.Where((line, index) => index % 2 == 1);
            File.WriteAllLines(@"D:\Daisy_Files\Desktop\text files\odd-lines.txt", oddLines);
        }
    }
}
