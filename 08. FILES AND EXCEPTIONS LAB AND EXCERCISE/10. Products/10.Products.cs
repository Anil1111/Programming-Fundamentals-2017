using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Product
{
    public string Type { get; set; }
    public string Name { get; set; }
    public double  Price { get; set; }
    public int Qunatity { get; set; }

}
class Program
{
        
    static void Main(string[] args)
    {
      var input = Console.ReadLine().Split(' ').ToList();
        List<Product> activeDataBase = new List<Product>();
        SortedDictionary<string, List<double>> sortedResult = new SortedDictionary<string,List<double>>();
        bool hasBeenReplaced = false;

        if (File.Exists("dataBase.txt"))
        {
           string[] currentLine = File.ReadAllLines("dataBase.txt");
            for (int i = 0; i < currentLine.Length; i++)
            {
                var currentEntry = currentLine[i].Split(' ');
                Product product = new Product()
                {
                    Name = currentEntry[0],
                    Type = currentEntry[1],
                    Price = double.Parse(currentEntry[2]),
                    Qunatity = int.Parse(currentEntry[3]),
                };
                activeDataBase.Add(product);
            }
         }

       while (input[0] != "exit" )
       {
            hasBeenReplaced = false;
            if (input[0] == "sales")
            {
                foreach (var kvp in activeDataBase)
                {
                    if (!sortedResult.ContainsKey(kvp.Type))
                    {
                        sortedResult[kvp.Type] = new List<double>();
                    }
                    sortedResult[kvp.Type].Add(kvp.Price * kvp.Qunatity);
                }
                var sum = 0.0;
                foreach (var entry in sortedResult)
                {
                    
                    Console.Write($"{entry.Key}: ");
                    foreach (var item in entry.Value)
                    {
                        sum += item;
                    }
                    Console.WriteLine($"${sum:f2}");
                    sum = 0.0;
                }
                input = Console.ReadLine().Split(' ').ToList();
                continue;
            }
            if (input[0] == "stock")
            {
                if (!File.Exists("dataBase.txt"))
                {
                    File.Create("dataBase.txt").Close();
                    break;
                }

                foreach (var entry in activeDataBase)
                {
                    File.AppendAllText("dataBase.txt", $"{entry.Type} {entry.Name} {entry.Price} {entry.Qunatity} {Environment.NewLine}");
                }
                input = Console.ReadLine().Split(' ').ToList();
                continue;
            }

            if (input[0] == "analyze")
              {
                if (!File.Exists("dataBase.txt"))
                {
                    Console.WriteLine($"No products stocked");
                    input = Console.ReadLine().Split(' ').ToList();
                    continue;
                }
                else
                {
                    var sortedByType = activeDataBase.OrderBy(x => x.Type).ThenBy(x => x.Name);
                    foreach (var item in sortedByType)
                    {
                        Console.WriteLine($"{item.Type},Product: {item.Name}\n\rPrice: ${item.Price},Amount Left:{item.Qunatity} ");
                    }
                    input = Console.ReadLine().Split(' ').ToList();
                    continue;
                }
            }

            var name = input[0];
            var type = input[1];
            var price = double.Parse(input[2]);
            var qunatity = int.Parse(input[3]);
            Product currentProduct = new Product()
            {
                Name = name,
                Type = type,
                Price = price,
                Qunatity = qunatity,
            };
            
               for (int i = 0; i < activeDataBase.Count; i++)
                {
                   var  entry = activeDataBase[i];
                    
                    if (entry.Name == name && entry.Type == type)
                   {
                    entry.Price = price;
                    entry.Qunatity = qunatity;
                    hasBeenReplaced = true; 
                    }
                }
            if (hasBeenReplaced == false)
            {
                activeDataBase.Add(currentProduct);
            }
            input = Console.ReadLine().Split(' ').ToList();

        }
    }

   
}

