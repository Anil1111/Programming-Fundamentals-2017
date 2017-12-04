using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Split_By_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] { ':', ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].All(char.IsLower))
                { lowerCase.Add(text[i]); }

                else if (text[i].All(char.IsUpper))
                { upperCase.Add(text[i]); }

                else
                {
                    mixedCase.Add(text[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ",upperCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ",mixedCase)}");

        }
    }
}
