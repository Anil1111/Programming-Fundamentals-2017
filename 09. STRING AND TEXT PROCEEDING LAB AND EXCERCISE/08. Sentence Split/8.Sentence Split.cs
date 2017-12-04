using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            List<string> db = new List<string>();
            StringBuilder result = new StringBuilder();

            while (input[0] != "end")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    var currentWord = input[0].ToCharArray();
                    var firstLetter = currentWord.Take(1).Select(char.ToUpper).ToString();
                    var otherLetters = currentWord.ToString().Skip(1).ToString();
                    result.Append(firstLetter);
                    result.Append(otherLetters);
                    Console.WriteLine();
                    
                }

                input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
