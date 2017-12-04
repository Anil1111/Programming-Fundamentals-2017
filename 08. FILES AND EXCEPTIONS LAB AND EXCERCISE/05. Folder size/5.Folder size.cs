using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5.Folder_size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filesList = Directory.GetFiles(@"D:\Daisy_Files\Desktop\text files\TestDrive");
            double sum = 0.0;

            foreach (var currentFile in filesList)
            {
                FileInfo file = new FileInfo(currentFile);
                sum += file.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText(@"D:\Daisy_Files\Desktop\text files\output.txt",sum.ToString());
            Console.WriteLine(sum);
        }
       
    }
}
