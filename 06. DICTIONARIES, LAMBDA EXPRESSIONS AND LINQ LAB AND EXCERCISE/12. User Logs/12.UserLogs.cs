using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, Dictionary<string,int>> DataBase = new Dictionary<string, Dictionary<string,int>>();
            var counter = 0;

            while (tokens[0] != "end")
            {
                List<string> ipDataBase = tokens[0].Split('=').ToList();
                var ip = ipDataBase[1];
                List<string> usersDataBase = tokens[2].Split('=').ToList();
                var user = usersDataBase[1];

                if (!DataBase.ContainsKey(ip))
                {
                    DataBase[user] = new Dictionary<string, int>();
                    DataBase[user][ip] = 1;
                }
                else
                {
                    DataBase[user][ip]++;
                }

                tokens = Console.ReadLine().Split(' ').ToList();
            }

            var orderedDataBase = DataBase.OrderBy(x => x.Key).ThenBy(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in orderedDataBase)
            {
                Console.WriteLine($"{kvp.Key} -> ");
                foreach (var ipCount in kvp.Value)
                {
                    var currentIp = ipCount.Key;
                    var currentCount = ipCount.Value;
                    Console.WriteLine($"    {currentIp} -> {currentCount}");
                }
            }

        }
    }
}
