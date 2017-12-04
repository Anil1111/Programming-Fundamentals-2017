using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9.Re_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"D:\Daisy_Files\Desktop\input");

            foreach (string file in files)
            {
                var extension = file.Substring(file.LastIndexOf(".") + 1);
                if (!Directory.Exists(extension))
                {
                    Directory.CreateDirectory(extension);
                }
                string currentFile = file.Substring(file.LastIndexOf("\\"));
                Directory.Move(@"D:\Daisy_Files\Desktop\input", extension + "s\\" + currentFile);
            }
        }
    }
}
