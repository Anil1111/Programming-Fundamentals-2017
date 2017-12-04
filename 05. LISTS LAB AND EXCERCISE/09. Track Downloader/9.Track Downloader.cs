using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blackListedWords = Console.ReadLine().Split(' ').ToList();
            var sortedTrackList = new List<string>();
            var inputLine = Console.ReadLine();
            bool doesContainBannedWord = false;

            while (inputLine != "end")
            {
                doesContainBannedWord = false;
                foreach (var bannedWord in blackListedWords)
                {
                    if (inputLine.Contains(bannedWord))
                    { doesContainBannedWord = true; }
                }
                if (doesContainBannedWord == false)
                { sortedTrackList.Add(inputLine); }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n\r",sortedTrackList));
        }
    }
}
