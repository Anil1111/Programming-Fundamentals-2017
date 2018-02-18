using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var field = new int[n];
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < field.Length; i++)
            {
                if (indexes.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }
            var inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                var tokens = inputLine.Split().ToList();
                var index = int.Parse(tokens[0]);
                var command = tokens[1];
                var fly = int.Parse(tokens[2]);
                
                if(command == "right")
                {
                    field[index] = 0;
                    
                    for (int i = index + fly; i < field.Length; i++)
                    {
                        if (field[i] == 0)
                        {
                            field[i] = 1;
                            break;
                        }
                    }
                }
                
                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}
