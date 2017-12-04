using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Registered_users
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var dataStored = new Dictionary<string, DateTime>();

            while (tokens[0] != "end")
            {
                var username = tokens[0];
                var dateString = tokens[1];
                DateTime dateTime = DateTime.ParseExact(dateString, "dd//MM/yyy", CultureInfo.InvariantCulture);

                if (!dataStored.ContainsKey(username))
                { dataStored[username] = dateTime; }
                tokens = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            // var result = dataStored.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x => x.Value).ToList();
            var result = dataStored.Reverse().OrderBy(x => x.Value).ToList();
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
        }
    }
}
