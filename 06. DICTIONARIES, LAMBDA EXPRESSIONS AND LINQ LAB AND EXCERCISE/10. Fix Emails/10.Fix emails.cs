using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fix_emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine();
            var emailToken = Console.ReadLine().Split('.').ToList();
            var dict = new Dictionary<string, string>();

            while (names != "stop")
            {
                if (!dict.ContainsKey(names))
                {
                    
                    dict[names] = emailToken;
                }
                if (emailToken[emailToken.Count] != "uk" || emailToken[emailToken.Count] != "us")
                { continue; }


            }
        }
    }
}
