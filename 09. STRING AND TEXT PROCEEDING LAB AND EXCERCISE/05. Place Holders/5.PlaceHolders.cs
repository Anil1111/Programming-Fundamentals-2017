using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PlaceHolders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var text = input[0].Trim();
            var elements = input[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine();

            while (input[0] != "end")
            {
                for (int i = 0; i < elements.Count; i++)
                {
                    if (text.Contains($"{{{i}}}"))
                    {
                       text = text.Replace($"{{{i}}}",elements[i]);
                    }
                }
                Console.WriteLine(text);
                input = Console.ReadLine().Split(new char[] {'-','>'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                text = input[0].Trim();
                elements = input[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            
            
        }
    }
}
