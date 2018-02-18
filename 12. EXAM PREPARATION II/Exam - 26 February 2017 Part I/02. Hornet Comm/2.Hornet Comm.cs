using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] {" <-> "}, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, string> broadcast = new Dictionary<string, string>();
            List<KeyValuePair<string, string>> message = new List<KeyValuePair<string, string>>();

            while (input[0] != "Hornet is Green")
            {
                var firstToken = input[0];
                var secondToken = input[1];

               
                var regexDigit = Regex.IsMatch(firstToken, @"(?<digits>[0-9]+)");
                var regexLetters = Regex.IsMatch(firstToken, @"(?<letters>[A-Za-z~!@#$%^&*()_+?><:{}| -]+)");
                var regexSomethingElse = Regex.IsMatch(secondToken, @"([~!@#$%^&*()_+?><:{}| -]+)");

                if (regexSomethingElse == true)
                {
                    input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    continue;
                }
                if (input.Count != 2)
                {
                    input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    continue;
                }
                if (regexDigit == true)
                {
                    AddToMessage(message,firstToken,secondToken);
                    
                }
                else if (regexLetters == true)
                {
                    AddToBroadcast(broadcast,firstToken,secondToken);
                }
                else if (regexSomethingElse == true)
                {
                    
                }

                
                input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Console.WriteLine();
            Console.WriteLine("Broadcasts:");
            foreach (var item in broadcast)
            {
                Console.WriteLine($"{item.Value} -> {item.Key}");
            }
            Console.WriteLine("Messages:");
            if (message.Count == 0)
            {
                Console.WriteLine("None");
            }
            foreach (var item in message)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }

       

        private static void AddToBroadcast(Dictionary<string, string> broadcast, string firstToken, string secondToken)
        {
            var msg = firstToken;
            var frequency = secondToken.ToCharArray();
            StringBuilder frqConverted = new StringBuilder();
            for (int i = 0; i < frequency.Length; i++)
            {
                if (char.IsLower(frequency[i]))
                {
                     var currentChar = char.ToUpper(frequency[i]);
                    frqConverted.Append(currentChar);
                }
                else
                {
                    var currentChar = char.ToLower(frequency[i]);
                    frqConverted.Append(currentChar);
                }
            }
            var finalFrequency = frqConverted.ToString();
            broadcast[msg] = finalFrequency;
        }

        private static void AddToMessage(List<KeyValuePair<string,string>> message, string firstToken, string secondToken)
        {
            var recipientCode = firstToken;
            char[] arr = recipientCode.ToCharArray();
            Array.Reverse(arr);
            var code = new string(arr);
            var msg = secondToken;

            message.Add(new KeyValuePair<string, string>(code, msg));

           
        }
    }
}
