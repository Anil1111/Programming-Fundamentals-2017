using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] {' ',',','.','!','?'},StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();
            foreach (var word in text)
            {
                if (word.SequenceEqual(word.Reverse()))
                {
                    palindromes.Add(word);
                }
            }
            palindromes = palindromes.OrderBy(x => x).Distinct().ToList();
            Console.WriteLine(string.Join(", ", palindromes));
        }
    }

}
