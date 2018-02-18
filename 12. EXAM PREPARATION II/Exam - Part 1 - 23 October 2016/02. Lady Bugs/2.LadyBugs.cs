using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] indexerOfDefaultLadybug = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] field = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (indexerOfDefaultLadybug.Contains(i))
                {

                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }

           
            
            
         //   int bug = 1;
            var input = Console.ReadLine();

            while (input!="end")
            {
                var tokens = input.Split().ToList();
                var ladyBugIndex =int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength =int.Parse(tokens[2]);

                switch (direction)
                {
                    case "right":
                        field[ladyBugIndex] = 0;
                        if (ladyBugIndex + flyLength >= field.Length)
                        {
                            field[ladyBugIndex] = 0;
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            for (int i = ladyBugIndex + flyLength; i <field.Length; i+= flyLength)
                            {
                                if (field[i] == 1)
                                {
                                    continue;
                                }

                                else
                                {
                                    field[i] = 0;
                                }
                            }
                           
                        }
                        break;
                    case "left":
                        field[ladyBugIndex] = 0;
                        if (field[ladyBugIndex - flyLength] < 0)
                        {
                            continue;
                        }
                        else
                        {
                            field[ladyBugIndex - flyLength] = 1;
                        }

                        break;

                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}
