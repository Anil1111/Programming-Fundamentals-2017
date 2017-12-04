using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"D:\Daisy_Files\Desktop\text files\text.txt");

            var numberedLines = fileLines.Select((line, index) => $"{index + 1}. {line}");
            File.WriteAllLines(@"D:\Daisy_Files\Desktop\text files\result.txt", numberedLines);
        }
    }
}
