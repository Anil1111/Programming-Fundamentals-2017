using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<int>> materialsBase = new Dictionary<string, List<int>>();
            Dictionary<string, List<int>> junk = new Dictionary<string, List<int>>();

            materialsBase["shards"] = new List<int>();
            materialsBase["fragments"] = new List<int>();
            materialsBase["motes"] = new List<int>();


            do
            {
                var tokens = Console.ReadLine().ToLower().Split(' ').ToList();
                int isDigit;
                for (int i = 0; i < tokens.Count - 1; i++)
                {
                    if (int.TryParse(tokens[i], out isDigit))
                    {
                        var currentMaterial = tokens[i + 1];
                        if (materialsBase.ContainsKey(currentMaterial))
                        {
                            materialsBase[currentMaterial].Add(isDigit);
                        }
                        else
                        {
                            if (!junk.ContainsKey(currentMaterial))
                            {
                                junk[currentMaterial] = new List<int>();

                            }
                            junk[currentMaterial].Add(isDigit);
                        }
                    }
                }


            } while (
                      materialsBase["shards"].Count < 250 ||
                      materialsBase["fragments"].Count < 250 ||
                      materialsBase["motes"].Count < 250
                     );


            string itemObtained = string.Empty;
            int pointsLeft = 0;

            foreach (var kvp in materialsBase)
            {
                var item = kvp.Key;
                var totalPoints = kvp.Value.Sum();
                if (totalPoints >= 250)
                {
                    itemObtained = item;
                    pointsLeft = totalPoints - 250;

                }
            }
            materialsBase[itemObtained].Clear();
            materialsBase[itemObtained].Add(pointsLeft);

            foreach (var kvp in materialsBase)
            {
                Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value)}");
            }


        }
    }
}
