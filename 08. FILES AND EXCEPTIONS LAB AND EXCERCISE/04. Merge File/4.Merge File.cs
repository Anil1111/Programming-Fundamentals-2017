using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Merge_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var readInput1 = File.ReadAllLines(@"D:\Daisy_Files\Desktop\text files\input1.txt");
             File.WriteAllLines(@"D:\Daisy_Files\Desktop\text files\merged_two_files.txt", readInput1);
            var readInput2 = File.ReadAllLines(@"D:\Daisy_Files\Desktop\text files\input2.txt");
            File.AppendAllLines(@"D:\Daisy_Files\Desktop\text files\merged_two_files.txt", readInput2);
            var resultFile = File.ReadAllLines(@"D:\Daisy_Files\Desktop\text files\merged_two_files.txt");
           var orderedAndMergedFiles = resultFile.OrderBy(x => x);
            File.WriteAllLines(@"D:\Daisy_Files\Desktop\text files\merged_two_files.txt",orderedAndMergedFiles);
        }
    }
}
