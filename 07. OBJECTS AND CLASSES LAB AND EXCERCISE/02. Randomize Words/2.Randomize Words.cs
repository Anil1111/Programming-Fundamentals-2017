using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').ToList();
            Random nextWord = new Random();
            for (int i = 0; i < tokens.Count-1; i++)
            {
                var pos = nextWord.Next(tokens.Count);
                var old = tokens[i+1];
                tokens[i] = tokens[pos];
                tokens[pos] = old;
                
                
            }
            Console.WriteLine(string.Join(" ",tokens));
        }
    }
}
