using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"D:\Daisy_Files\Desktop\text files\text.txt");
            string[] words = File.ReadAllText(@"D:\Daisy_Files\Desktop\text files\words.txt").ToLower().Split(new char[] { '\n', '\r',' ',',','.','!','?','-' },StringSplitOptions.RemoveEmptyEntries);
            var wordsCount = new Dictionary<string, int>();

            foreach (var word in lines)
            {
                wordsCount[word] = 0;
            }
            foreach (var word in words)
            {
                if (wordsCount.ContainsKey(word))
                { wordsCount[word]++; }
            }
            var sortedResult = wordsCount.OrderByDescending(w => w.Value).ToDictionary(w => w.Key, w => w.Value);

              File.WriteAllText(@"D:\Daisy_Files\Desktop\text files\counted_and_sorted.txt",
              
        }
    }
}
