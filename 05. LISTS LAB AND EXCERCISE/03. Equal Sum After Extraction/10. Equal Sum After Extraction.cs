using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondaryList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < primeList.Count; i++)
            {
                for (int j = 0; j < secondaryList.Count; j++)
                {
                    if (primeList[i] == secondaryList[j])
                    {
                        secondaryList.RemoveAt(j);
                        j--;
                    }
                }
            }

            var sumPrimeList = primeList.Sum();
            var sumSecondaryList = secondaryList.Sum();
            Console.WriteLine(sumPrimeList);
            Console.WriteLine(sumSecondaryList);
            Console.WriteLine(string.Join(", ",secondaryList));
        }
    }
}
