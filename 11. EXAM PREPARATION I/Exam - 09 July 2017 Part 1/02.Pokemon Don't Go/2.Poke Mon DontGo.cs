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

            while (sequence.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());
                var removedElement = sequence[index];
                sequence.RemoveAt(index);
                for (int i = 0; i < sequence.Count - 1; i++)
                {
                    var currentElement = sequence[i];
                    if (removedElement >= currentElement)
                    {
                        currentElement++;
                    }
                    else if (currentElement >= removedElement)
                    {
                        currentElement--;
                    }
                }
                if(index < 0)
                {
                    sequence[0] = 0;
                    var lastElement = sequence[sequence.Count - 1];
                    sequence[0] = lastElement;
                }
                if(index > sequence[sequence.Count-1])
                {
                    sequence[sequence.Count - 1] = sequence[0];

                }
            }
        }
    }
}
