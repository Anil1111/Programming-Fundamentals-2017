using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Character_Multiplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var txt1 = input[0];
            var txt2 = input[1];

            CharacterMupliply(txt1,txt2);
        }

        private static void CharacterMupliply(string txt1, string txt2)
        {
            
            var string1 = txt1;
            var string2 = txt2;
            var sum = 0;

            for (int i = 0; i < string1.Length; i++)
            {
                if (i < string1.Length)
                {
                    sum += string1[i] * string2[i];
                }
                else
                {
                    sum += string2[i];
                }
            }
            Console.WriteLine(sum);
            
            
        }
    }
}
