using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Ununion_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            var input = new List<int>();
            bool wasFound = false;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j <input.Count ; j++)
                {
                    wasFound = false;

                    var currentNumber = input[j];

                    for (int k = 0; k < primalList.Count; k++)
                    {
                        if (currentNumber == primalList[k])
                        {
                            wasFound = true;
                        }
                    }
                    if (wasFound == false)
                    { primalList.Add(currentNumber); }
                    else if (wasFound == true)
                    { primalList.Remove(currentNumber); }
                }

                
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ",primalList ));
        }
    }
}
