using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3.Nether_realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var digitsRegex = @"(?<digits>[-|+0-9\.]+)";
            var lettersRegex = @"(?<letters>[a-zA-Z])";
            var damage = 0.0;
            var health = 0.0;
            var digitsConverted = new List<double>();

            for (int i = 0; i < input.Count; i++)
            {
                health = 0;
                damage = 0;
                var currentName = input[i].Trim();

                var digitsMatches = Regex.Matches(currentName,digitsRegex);
                foreach (Match digit in digitsMatches)
                {
                    var currentDigit = Convert.ToDouble(digit.Groups["digits"].Value);
                    digitsConverted.Add(currentDigit);
                }
                for (int d = 0; d < digitsConverted.Count; d++)
                {
                    damage += digitsConverted[d];
                }
                if (currentName.Contains('*'))
                {
                    damage = damage * 2 * 2;
                }

                var healthMatches = Regex.Matches(currentName,lettersRegex);
                foreach (Match letter in healthMatches)
                {
                    var currentAscii = letter.Groups["letters"].Value.ToCharArray();
                    health +=(double)(currentAscii[0]);
                }
                Console.WriteLine($"{currentName} - {health} health, {damage} damage");
                
            }

        }
    }
}
