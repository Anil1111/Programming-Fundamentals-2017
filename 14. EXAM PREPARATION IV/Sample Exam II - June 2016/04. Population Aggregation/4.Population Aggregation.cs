using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class CountryInfo
{
    public string Country { get; set; }
    public City City{ get; set; }
}
class City
{
    public string Town { get; set; }
    public long Population { get; set; } = 0;
}
class Program
{
    static void Main(string[] args)
    {

        string inoutLine = Console.ReadLine();
        List<CountryInfo> countryDataBase = new List<CountryInfo>();

        while (inoutLine != "stop")
        {
            var tokens = inoutLine.Split('\\').ToList();

            if (Regex.IsMatch(tokens[0], @"[A-Z]"))
            {
                var country = Regex.Replace(tokens[0], @"[><$&@#0-9]", "");
                var city = Regex.Replace(tokens[1], @"[><$&@#0-9]", "");

                CountryInfo currentCountry = new CountryInfo
                {
                    Country = country,
                    City = new City
                    {
                        Town = city,
                        Population = long.Parse(tokens[2])
                    }
                };

                //if the country already exist in the dataBase...
                if (countryDataBase.Any(x => x.Country == country))
                {
                    var indexC = countryDataBase.FindIndex(x => x.Country == country);
                    //...we check if the city already exist,and add only the POPULATION...
                    if (countryDataBase[indexC].City.Town == city)
                    {
                        countryDataBase[indexC].City.Population = long.Parse(tokens[2]);

                    }
                    //...if it doesn't exist, we add the CITY and the POPULATION
                    else
                    {
                        countryDataBase[indexC].City.Town = city;
                        countryDataBase[indexC].City.Population = long.Parse(tokens[2]);

                    }
                }
                else
                {
                    countryDataBase.Add(currentCountry);
                }
                inoutLine = Console.ReadLine();

            }
            else
            {
                var country = Regex.Replace(tokens[1], @"[><$&@#0-9]", "");
                var city = Regex.Replace(tokens[0], @"[><$&@#0-9]", "");

                CountryInfo currentCountry = new CountryInfo
                {
                    Country = country,
                    City = new City
                    {
                        Town = city,
                        Population = long.Parse(tokens[2])
                    }
                };

                //if the country already exist in the dataBase...
                if (countryDataBase.Any(x => x.Country == country))
                {
                    var indexC = countryDataBase.FindIndex(x => x.Country == country);
                    //...we check if the city already exist,and add only the POPULATION...
                    if (countryDataBase[indexC].City.Town == city)
                    {
                        countryDataBase[indexC].City.Population = long.Parse(tokens[2]);

                    }
                    //...if it doesn't exist, we add the CITY and the POPULATION
                    else
                    {
                        countryDataBase[indexC].City.Town = city;
                        countryDataBase[indexC].City.Population = long.Parse(tokens[2]);

                    }
                }
                else
                {
                    countryDataBase.Add(currentCountry);
                }
                inoutLine = Console.ReadLine();
            }



        }
        var ordered = countryDataBase.OrderByDescending(x => x.City.Population).Take(3);
        foreach (var country in countryDataBase.OrderBy(x => x.Country))
        {
            Console.WriteLine($"{country.Country} - > {country.City.Town.Count()}");
        }
        foreach (var item in ordered)
        {
            Console.WriteLine($"{item.City.Town} -> {item.City.Population}");
        }


    }




}
    









