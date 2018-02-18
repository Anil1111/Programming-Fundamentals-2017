using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool found = true;

           
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (i == 0 || i == sequence.Count -1)
                    {
                        continue;
                    }
                    if (sequence[i] == sequence[i - 1] + sequence[i + 1])
                    {
                        sequence.Remove(sequence[i-1]);

                        var lastIndex = sequence.FindLastIndex(x => x == sequence[i]);
                        sequence.RemoveAt(lastIndex);
                        i = 0;
                    }
                }
            Console.WriteLine(string.Join(" ",sequence));
            
        }
    }
}
