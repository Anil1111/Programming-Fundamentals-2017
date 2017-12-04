using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> zippedList = new List<int>(firstList);

            for (int i = 1; i < secondList.Count; i+=2)
            {
                
                 secondList.Insert(i,firstList[i]); 
            }



        }
    }
}
