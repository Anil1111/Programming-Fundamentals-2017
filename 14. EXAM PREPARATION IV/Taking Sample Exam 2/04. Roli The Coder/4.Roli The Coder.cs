using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//class Participant
//{
//    public string Name { get; set; }
//}
class Program
{
    static void Main(string[] args)
    {
        SortedDictionary<string, string> idEvent = new SortedDictionary<string, string>();
        SortedDictionary<string,List<string>> eventParticipants = new SortedDictionary<string,List<string>>();

        var input = Console.ReadLine();
        while (input != "Time for Code")
        {
            if (!input.Contains('#'))
            {
                input = Console.ReadLine();
                continue;
            }
            var tokens = input.Split().ToList();
            if (tokens.Count < 2)
            {
                input = Console.ReadLine();
                continue;
            }
            var id = tokens[0];
            var evenT =tokens[1].TrimStart('#');
            List<string> participants = new List<string>();

            for (int i = 2; i < tokens.Count; i++)
            {
               
                    participants.Add(tokens[i]);
               
            }

           
            
            if (!idEvent.ContainsKey(id) && !idEvent.ContainsValue(evenT))
            {
                idEvent[id] = evenT;
                eventParticipants[evenT] = new List<string>();
                eventParticipants[evenT].AddRange(participants);
            }
            else
            {
                if (idEvent[id].Contains(evenT))
                {
                    foreach (var participant in participants)
                    {
                        if (!eventParticipants[evenT].Contains(participant))
                        {
                            eventParticipants[evenT].Add(participant);
                        }
                    }
                }
            }

    

            input = Console.ReadLine();
        }

       
        foreach (var eventPart in eventParticipants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{eventPart.Key} - {eventPart.Value.Count()}");
            foreach (var participant in eventPart.Value.OrderBy(x => x))
            {
                Console.WriteLine($"{string.Join(" ",participant)}");
            }
        }
        
    }
}
