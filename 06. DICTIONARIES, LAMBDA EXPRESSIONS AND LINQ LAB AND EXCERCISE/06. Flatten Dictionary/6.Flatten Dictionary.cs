using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var keyInnerKey = new Dictionary<string,Dictionary<string,string>>();

            while (input[0] != "end")
            {
                if (input[0] == "flatten")
                {

                }
                var key = input[0];
                var innerKey = input[1];
                var innerValue = input[2];

                if (!keyInnerKey.ContainsKey(key))
                { keyInnerKey[key] = new Dictionary<string, string>(); }
                
                keyInnerKey[key][innerKey] = innerValue;
            }
        }
    }
}
