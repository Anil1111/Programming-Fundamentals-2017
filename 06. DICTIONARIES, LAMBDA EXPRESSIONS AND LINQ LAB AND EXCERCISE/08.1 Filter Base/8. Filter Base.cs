using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split().ToList();
            var ageDataBase = new Dictionary<string, int>();
            var salaryDataBase = new Dictionary<string, double>();
            var positionDatabase = new Dictionary<string, string>();

            while (true)
            {

                if (tokens[0] == "filter base") { break; }
                int intNumb = 0;
                double doubleNumb = 0.0;
                bool isInteger = false;
                bool isDouble = false;

                isInteger = int.TryParse(tokens[2], out intNumb);
                isDouble = double.TryParse(tokens[2], out doubleNumb);

                if (isInteger == true)
                { ageDataBase[tokens[0]] = intNumb; }

                else if (isInteger != true)
                { salaryDataBase[tokens[0]] = doubleNumb; }

                else
                { positionDatabase[tokens[0]] = tokens[2]; }





                tokens = Console.ReadLine().Split().ToList();
            }
            var input = Console.ReadLine();
            if (input == "age")
            {
                foreach (var kvp in ageDataBase)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
                if (input == "salary")
                {
                    foreach (var kvp in salaryDataBase)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
                if (input == "position")
                {
                    foreach (var kvp in positionDatabase)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
            }
        }
    }
}
