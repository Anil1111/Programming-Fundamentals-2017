using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Winecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int growthDay = int.Parse(Console.ReadLine());

            for (int i = 0; i < growthDay; i++)
            {
                for (int k = 0; k < grapes.Count ; k++)
                {
                    grapes[k] += 1;
                }
            }
        }
    }
}
