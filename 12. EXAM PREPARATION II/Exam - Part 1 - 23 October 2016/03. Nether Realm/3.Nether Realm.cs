using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class Monster
{
    public string Name { get; set; }
    public double Health { get; set; } = 0;
    public double Damage { get; set; } = 0;
}
class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList(); ;
        HashSet<Monster> monsters = new HashSet<Monster>();

        for (int i = 0; i < input.Count; i++)
        {

            var name = input[i];
            var regexForDigits = @"(?<digits>[-|0-9.]+)";
            var regexForLetters = @"(?<letters>[A-Za-z])";
            List<string> digits = new List<string>();
            List<string> chars = new List<string>();
            var sumHealth = 0.0;
            var sumDamage = 0.0;

            MatchCollection digitsMatches = Regex.Matches(name, regexForDigits);
            foreach (Match item in digitsMatches)
            {
                digits.Add(item.Groups["digits"].Value);
            }
            MatchCollection charsMatches = Regex.Matches(name, regexForLetters);
            foreach (Match item in charsMatches)
            {
                chars.Add(item.Groups["letters"].Value);
            }
            foreach (var letter in chars)
           {
                var toChar = Convert.ToChar(letter);
                sumHealth += toChar;
            }
            foreach (var entry in digits)
            {
                var currentDigit = Convert.ToDouble(entry);
                sumDamage += currentDigit;
            }
            var regexFinalOperations = @"(?<operations>[*/])";
            var operations = Regex.Matches(name, regexFinalOperations);
            List<string> operationsFinale = new List<string>();
            foreach (Match item in operations)
            {
                operationsFinale.Add(item.Groups["operations"].Value);
            }

            for (int k = 0; k < operationsFinale.Count; k++)
            {
                if (operationsFinale[k] == "*")
                {
                    sumDamage *= 2;
                }
                else
                {
                    sumDamage /= 2;
                }
            }
            Monster currentMonster = new Monster
            {
                Name = name,
                Health = sumHealth,
                Damage = sumDamage,
            };
            monsters.Add(currentMonster);
        }
        foreach (var item in monsters)
        {
            Console.WriteLine($"{item.Name}  - {item.Health} health, {item.Damage} damage");
          
        }
    }
}

