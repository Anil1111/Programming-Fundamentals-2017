using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = Console.ReadLine().Split(' ').ToList();
            var dict = new Dictionary<string, string>();
            var userName = token[0];
            var password = token[2];

            while (true)
            {
                userName = token[0];
                if (userName == "login")
                { break; }
              
                password = token[2];

                dict[userName] = password;

                token = Console.ReadLine().Split(' ').ToList();
            }
            var unsuccessfulLogins = 0;
            token = Console.ReadLine().Split(' ').ToList();
            while (true)
            {
                userName = token[0];
                if (userName == "end")
                { break; }
                
                password = token[2];

                bool match = false;
                foreach (var kvp in dict)
                {
                    if (userName == kvp.Key && password == kvp.Value)
                    { match = true; break; }
                    
                }
                if (match == true)
                { Console.WriteLine($"{userName}: logged in successfully"); }
                else
                {
                    unsuccessfulLogins++;
                    Console.WriteLine($"{userName}: login failed");
                }


                token = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine($"unsuccessful login attempts: {unsuccessfulLogins}");
        }
    }
}
