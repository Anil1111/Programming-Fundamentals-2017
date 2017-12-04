using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var tokens = Console.ReadLine().Split(' ').ToList();
            SortedDictionary<string, List<int>> userCount = new SortedDictionary<string, List<int>>();
            SortedDictionary<string, HashSet<string>> userIP = new SortedDictionary<string, HashSet<string>>();
            var counter = 0;

            for (int i = 0; i < n; i++)
            {
                var ip = tokens[0];
                var user = tokens[1];
                var count =int.Parse(tokens[2]);

                if(!userCount.ContainsKey(user))
                {
                    userCount[user] = new List<int>();
                    userIP[user] = new HashSet<string>();
                }
                userCount[user].Add(count);
                userIP[user].Add(ip);

                tokens = Console.ReadLine().Split(' ').ToList();

            }
            var sum = 0;
            foreach (var users in userCount)
            {
                Console.Write($"{users.Key}: {users.Value.Sum()} ");
                foreach (var ip in userIP)
                {
                    var IP = ip.Value.OrderBy(x => x);
                    var currentUser = users.Key;
                    var user = ip.Key;
                    if (user == currentUser)
                    {
                        Console.Write($"[{string.Join(", ", IP)}]");
                    }
                }
                Console.WriteLine();
                
            }
          
        }
    }
}
