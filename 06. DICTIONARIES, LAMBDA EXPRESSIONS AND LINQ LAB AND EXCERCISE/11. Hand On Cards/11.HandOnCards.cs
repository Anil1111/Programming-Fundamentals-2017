using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.HandOnCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(new char[] { ':', }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> result = new Dictionary<string, int>();
            
            while (tokens[0] != "JOKER")
            {
                var name = tokens[0];
                List<string> cards = tokens[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();


                tokens = Console.ReadLine().Split(new char[] { ':', }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }
    }
}
