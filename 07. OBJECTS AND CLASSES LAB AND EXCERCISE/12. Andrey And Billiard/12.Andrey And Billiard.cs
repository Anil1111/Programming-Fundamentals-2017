using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Customer
{
    public string Name { get; set; }
    public Dictionary<string, double> ShopList { get; set; }


}
class Program
    {
    

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Dictionary<string, double> shop = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-').ToList();
                if (!shop.ContainsKey(input[0]))
                {
                    shop.Add(input[0], double.Parse(input[1]));
                }
                else
                {
                    shop[input[0]] = double.Parse(input[1]);
                }
            }

        Customer customerDataBase = new Customer();
        customerDataBase.ShopList = new Dictionary<string, double>();
        var tokens = Console.ReadLine().Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        
            while (tokens[0] !="end of clients")
            {

            var customer = tokens[0];
            var product = tokens[1];
            var quantity =double.Parse(tokens[2]);

            if (!shop.ContainsKey(product))
            {
                tokens = Console.ReadLine().Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                continue; }

            else if(shop.ContainsKey(product))
            {
                var bill = quantity * shop[product];
                customerDataBase.Name = customer;
                

                if (!customerDataBase.ShopList.ContainsKey(customer))
                {
                    customerDataBase.ShopList[customer] = bill;
                }
                else
                {
                    customerDataBase.ShopList[customer] = bill;
                }
            }


                tokens = Console.ReadLine().Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        foreach (var studen in customerDataBase.ShopList)
        {
            Console.WriteLine(studen.Key);
            foreach (var item in customerDataBase.ShopList)
            {
                Console.WriteLine($"    {item.Value} -");
            }
        }

        }
    }

