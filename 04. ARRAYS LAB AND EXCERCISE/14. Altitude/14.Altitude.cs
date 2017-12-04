using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ').ToArray();
            string[] commands = new string[tokens.Length/2];
            int[] altitude = new int[tokens.Length/2];
            int initialAltitude =int.Parse(tokens[0]);
            bool hasCrashed = false;

            for (int i = 0; i < commands.Length; i++)
            {
                if ( initialAltitude < 0 || initialAltitude == 0 )
                {
                    
                    hasCrashed = true;
                    break;
                }

                if (commands[i] == "up")
                { initialAltitude += altitude[i]; }

                else if (commands[i] == "down")
                { initialAltitude -= altitude[i]; }
            }
            if (hasCrashed == false)
            {
                Console.WriteLine($"got through safely. current altitude: {initialAltitude}m.");
            }
            else if(hasCrashed == true)
            { Console.WriteLine("crashed"); }
        }
    }
}
