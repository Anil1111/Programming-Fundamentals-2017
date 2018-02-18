using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Worms_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            while (true)
            {
                var counter = 0;
                var tokens = input.Split(' ').ToList();
                for (int i = 0; i < tokens.Count; i++)
                {
                    if (tokens[i].Contains('.'))
                    {
                        counter++;
                    }
                }
                if (counter > 1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                   
                    
                }
                input = Console.ReadLine();
            }
        }
    }
}
