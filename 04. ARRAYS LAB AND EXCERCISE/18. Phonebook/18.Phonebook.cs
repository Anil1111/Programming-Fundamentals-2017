using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string inputLine = Console.ReadLine();
            int currentIndex = 0;
            List<char> currentPhoneNumber = new List<char>();
            int sum = 0;

            while (inputLine != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (inputLine == names[i])
                    {
                        currentIndex = i;
                    }
                }
                Console.WriteLine($"{inputLine} -> {phoneNumbers[currentIndex]}");
                Console.WriteLine($"call {names[currentIndex]} -> calling {phoneNumbers[currentIndex]}...");
                
                currentPhoneNumber.Add(Convert.ToChar(phoneNumbers[currentIndex]));
                for (int i = 0; i < currentPhoneNumber.Count; i++)
                {
                    if (currentPhoneNumber[i] >= 48 && currentPhoneNumber[i] <= 57)
                    {
                        sum += currentPhoneNumber[i];
                    }
                }

                if (sum % 2 != 0)
                { Console.WriteLine("no answer"); }
                else
                { Console.WriteLine("meet me there"); }

                inputLine = Console.ReadLine();
            }
        }
    }
}
