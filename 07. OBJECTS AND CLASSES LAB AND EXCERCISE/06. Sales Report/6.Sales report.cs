using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public double Price { get; set; }
    public double Quantity  { get; set; }

    public static Sale ReadSale()
    {
        var sale = Console.ReadLine().Split(' ').ToList();
        Sale currentSale = new Sale() {Town = sale[0],Product = sale[1],Price = double.Parse(sale[2]), Quantity =double.Parse(sale[3]) };
        return currentSale;
    }


}
    class Program
    {
        static void Main(string[] args)
        {

        
        var n = int.Parse(Console.ReadLine());
        List<Sale> salesDataBase = new List<Sale>();
        for (int i = 0; i < n; i++)
        {
            Sale currentSale = Sale.ReadSale();
            salesDataBase.Add(currentSale);

        }
        var sortedByTown = salesDataBase.OrderBy(x => x.Town).ToList();
        Dictionary<string,List<double>> finalresult = new Dictionary<string,List<double>>();

           foreach (var cuurentSale in sortedByTown)
        {
            var priceQuantity = cuurentSale.Price * cuurentSale.Quantity;
            if (!finalresult.ContainsKey(cuurentSale.Town))
            {

                finalresult[cuurentSale.Town] = new List<double>();
                finalresult[cuurentSale.Town].Add(priceQuantity);
            }
            else
            {
                finalresult[cuurentSale.Town].Add(priceQuantity);
            }
        }
        foreach (var kvp in finalresult)
        {
            var totalSum = kvp.Value;
            Console.Write($"{kvp.Key} -> {kvp.Value}");
           
        }

       

    }

}


