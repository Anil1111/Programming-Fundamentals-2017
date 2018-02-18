using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            List<int> digit = new List<int>();
            List<char> result = new List<char>();
            Dictionary<string, string> pendingCollection = new Dictionary<string, string>();


            var inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                var tokens = inputLine.Split(new string[] { "TO: ", "; MESSAGE:", ";", }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var recipient = tokens[0];
                var msg = tokens[1].TrimStart();

                while (key > 0)
                {
                    var lastNum = key % 10;
                    key /= 10;
                    digit.Add(lastNum);

                }
                digit.Reverse();

                for (int i = 0; i < msg.Length; i++)
                {
                    var currentLetter = (int)msg[i];
                    var shifter = digit[i % digit.Count];
                    var resultLetter = (char)(currentLetter + shifter);
                    result.Add(resultLetter);
                }
                var toStr = string.Join("", result);
                pendingCollection[recipient] = toStr.ToUpper();
                inputLine = Console.ReadLine();
                result.Clear();

                
              
            }
            foreach (var entry in pendingCollection.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{entry.Value}");
            }

        }
    }
}
