using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Evolution
{
    public string Type { get; set; }
    public int Index { get; set; } = 0;
}

class Program
{
    static void Main(string[] args)
    {
        var inputLine = Console.ReadLine().Split(new string[] { " -> " },StringSplitOptions.RemoveEmptyEntries).ToList();
        Dictionary<string, List<Evolution>> pokemons = new Dictionary<string, List<Evolution>>();

        while (true)
        {
            if (inputLine[0] == "wubbalubbadubdub")
            { break; }
            if (inputLine.Count != 1)
            {
                var Name = inputLine[0];
                var type = inputLine[1];
                var Index = int.Parse(inputLine[2]);

                if (!pokemons.ContainsKey(Name))
                {
                    pokemons[Name] = new List<Evolution>();
                    Evolution currentPokemon = new Evolution
                    {
                        Type = type,
                        Index = Index,
                    };
                    pokemons[Name].Add(currentPokemon);
                }
                else
                {
                    //if (pokemons[Name].Any(x => x.Type == type))
                    //{
                    //    var indexP = pokemons[Name].FindIndex(x => x.Type == type);
                    //    pokemons[Name][indexP].Index = Index;
                    //}
                   // else
                    //{
                        pokemons[Name].Add(new Evolution {Type = type,Index = Index });
                    //}
                }
                


            }
            else
            {
                string currentPokemon = inputLine[0];
                
                if (pokemons.ContainsKey(currentPokemon))
                {
                    foreach (var pokemone in pokemons[currentPokemon])
                    {
                        Console.WriteLine($"{pokemone.Type} -> {pokemone.Index}");
                    }
                }
            }

           inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
        foreach (var poke in pokemons)
        {
            Console.WriteLine($"# {poke.Key}");
            foreach (var evol in poke.Value.OrderByDescending(x => x.Index))
            {
                Console.WriteLine($"{evol.Type} <-> {evol.Index}");
            }
                
        }
    }
}

