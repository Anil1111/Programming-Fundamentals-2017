using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries).ToList();
            var text = Console.ReadLine(); 

            foreach (var bannedWord in bannedWords)
            {
                if(text.Contains(bannedWord))
                {
                    text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
