using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var quantities = int.Parse(Console.ReadLine());
            var minerBase = new Dictionary<string, int>();
           
           

            while (true)
            {
                if (input == "stop")
                { break; }
               

                if (!minerBase.ContainsKey(input))
                {
                    minerBase[input] = 0;
                }
               
                
                    quantities.Add(int.Parse(input));
                

            }
            foreach (var kvp in minerBase)
            {

            }
        }
    }
}
