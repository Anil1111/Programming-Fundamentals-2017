using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class CoffeeDrinker
{
    public string Name{ get; set; }
    public Coffee CoffeeType{ get; set; }
}
class Coffee
{
    public string Name { get; set; }
    public int Quantity { get; set; } = 0;
}
class Program
{
    static void Main(string[] args)
    {
        List<CoffeeDrinker> coffeeDrinkers = new List<CoffeeDrinker>();
        List<Coffee> coffeeInventor = new List<Coffee>();
        var delimeters = Console.ReadLine().Split(' ').ToList();
        var deli1 = delimeters[0];
        var deli2 = delimeters[1];
        var inputLine = Console.ReadLine();
        while (inputLine !="end of info")
        {
            if (Regex.IsMatch(inputLine, deli1))
            {

                var tokens = inputLine.Split(char.Parse(deli1)).ToList();
                var name = tokens[0];
                var coffee = tokens[1];
                CoffeeDrinker currentDrinker = new CoffeeDrinker
                {
                    Name = name,
                    CoffeeType = new Coffee
                    {
                        Name = coffee,
                    }
                };
                coffeeDrinkers.Add(currentDrinker);

                if(!coffeeInventor.Any(x => x.Name == currentDrinker.CoffeeType.Name))
                {
                    Coffee currentCoffee = new Coffee
                    {
                        Name = currentDrinker.CoffeeType.Name
                    };
                    coffeeInventor.Add(currentCoffee);
                    
                }
                coffeeDrinkers.Add(currentDrinker);
            }
            else
            {
                var tokens = inputLine.Split(char.Parse(deli2)).ToList();
                var name = tokens[0];
                var quantity = int.Parse(tokens[1]);
                Coffee currentCoffee = new Coffee
                {
                    Name = name,
                    Quantity = quantity
                };
                if (coffeeDrinkers.Any(x => x.Name == name))
                {
                    //find which is the index of the current input NAME in the "coffeeDrinker" data base;
                    var indexOfPerson = coffeeDrinkers.FindIndex(x => x.Name == name);
                    
                    //after this you use the index to find what type of coffe,to that same input NAME, is assigned;
                    var coffeeName = coffeeDrinkers[indexOfPerson].CoffeeType.Name;

                    //and then you look for the index of that same coffee type in the "coffeeInventor" data base;
                    var indexOfCup = coffeeInventor.FindIndex(x => x.Name == coffeeName);

                    //and then you change the quantity.
                    coffeeInventor[indexOfCup].Quantity -= quantity;

                    //if there is not enough coffee in the inventor
                    if (coffeeInventor[indexOfCup].Quantity <= 0)
                    {
                        Console.WriteLine($"out of coffee {name}");
                    }
                    
                }


            }

            inputLine = Console.ReadLine();
        }
        inputLine = Console.ReadLine();
        while (inputLine !="end of week")
        {
            var tokens = inputLine.Split(char.Parse(deli2))

            inputLine = Console.ReadLine();
        }


    }
}

