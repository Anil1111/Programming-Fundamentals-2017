using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> frequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            List<string> notes = new List<string>();
            double naturalsSum = 0.0;
            double sharpsSum = 0.0;
          

            for (int i = 0; i < frequencies.Count; i++)
            {
                double currentFrequencie = frequencies[i];

                

                if (currentFrequencie == 261.63)
                {
                    notes.Add("C");
                    naturals.Add("C");
                    naturalsSum += currentFrequencie;
                }

                else if (currentFrequencie == 277.18)
                {
                    notes.Add("C#");
                    sharps.Add("C#");
                    sharpsSum += currentFrequencie;
                }
                else if (currentFrequencie == 293.66)
                {
                    notes.Add("D");
                    naturals.Add("D");
                    naturalsSum += currentFrequencie;
                }
                else if (currentFrequencie == 311.13)
                {
                    notes.Add("D#");
                    sharps.Add("D#");
                    sharpsSum += currentFrequencie;
                }
                else if (currentFrequencie == 329.63)
                {
                    notes.Add("E");
                    naturals.Add("E");
                    naturalsSum += currentFrequencie;
                }
                else if (currentFrequencie == 349.23)
                {
                    notes.Add("F");
                    naturals.Add("F");
                    naturalsSum += currentFrequencie;
                }
                else if (currentFrequencie == 369.99)
                {
                    notes.Add("F#");
                    sharps.Add("F#");
                    sharpsSum += currentFrequencie;
                }
                else if (currentFrequencie == 392.00)
                {
                    notes.Add("G");
                    naturals.Add("G");
                    naturalsSum += currentFrequencie;
                }
                else if (currentFrequencie == 415.30)
                {
                    notes.Add("G#");
                    sharps.Add("G#");
                    sharpsSum += currentFrequencie;
                }
                else if (currentFrequencie == 440.00)
                {
                    notes.Add("A");
                    naturals.Add("A");
                    naturalsSum += currentFrequencie;
                }
                else if (currentFrequencie == 466.16)
                {
                    notes.Add("A#");
                    sharps.Add("A#");
                    sharpsSum += currentFrequencie;
                }
                else if (currentFrequencie == 493.88)
                {
                    notes.Add("B");
                    naturals.Add("B");
                    naturalsSum += currentFrequencie;
                }


            }
            Console.WriteLine($"Notes: {string.Join(" ",notes)}");
            Console.WriteLine($"Naturals: {string.Join(", ",naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ",sharps)}");
            Console.WriteLine($"Naturals sum: {string.Join(" ",naturalsSum)}");
            Console.WriteLine($"Sharps sum: {string.Join(" ",sharpsSum)}");
        }
    }
}
