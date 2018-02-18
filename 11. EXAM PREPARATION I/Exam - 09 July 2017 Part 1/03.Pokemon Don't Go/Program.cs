using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Poke_Mon_Don_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var removed= new List<int>();

            while (sequence.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());
                if (index <0 || index > sequence.Count - 1)
                {
                    if (sequence.Count != 0)
                    {
                        if (index < 0)
                        {
                            sequence[0] = 0;
                            var lastElement = sequence[sequence.Count - 1];
                            sequence[0] = lastElement;
                        }
                        if (index > sequence.Count - 1)
                        {
                            sequence[sequence.Count - 1] = sequence[0];

                        }
                    }
                }
                else
                {

                    var removedElement = sequence[index];
                    removed.Add(removedElement);
                    sequence.RemoveAt(index);
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        var currentElement = sequence[i];
                        if (removedElement >= currentElement)
                        {
                            sequence[i] += removedElement;
                        }
                        else if (currentElement >= removedElement)
                        {
                            sequence[i] -= removedElement;
                        }
                    }
                   

                }
                   
                
               
            }
            Console.WriteLine(removed.Sum());
        }
    }
}
