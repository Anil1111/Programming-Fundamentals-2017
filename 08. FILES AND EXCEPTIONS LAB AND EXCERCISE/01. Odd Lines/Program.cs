using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"D:\Daisy_Files\Desktop\text files\text.txt");
            var oddLines = fileLines.Where((line, index) => index % 2 == 1);
            File.WriteAllLines(@"D:\Daisy_Files\Desktop\text files\output.txt", oddLines);
        }
    }
}
