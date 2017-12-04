using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Merge_words
{
    class Program
    {
        static void Main(string[] args)
        {
             var text1 = File.ReadAllText(@"D:\Daisy_Files\Desktop\text files\input1.txt");
            var text2 = File.ReadAllText(@"D:\Daisy_Files\Desktop\text files\input2.txt");
            var appended = File.AppendAllText(@"D:\Daisy_Files\Desktop\appended.txt", text1, text2);
        }
    }
}
