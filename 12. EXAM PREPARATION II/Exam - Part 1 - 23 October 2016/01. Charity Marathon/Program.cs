using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___Part_1___23_October_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = double.Parse(Console.ReadLine());
            var runnersCount = double.Parse(Console.ReadLine());
            var averageLapsPerRunner = double.Parse(Console.ReadLine());
            var trackLength = double.Parse(Console.ReadLine());
            var capacityOfTrack = double.Parse(Console.ReadLine());
            var donationPerKM = double.Parse(Console.ReadLine());
            var moneyRaised =0.0;

            if (runnersCount > capacityOfTrack)
            {
                
                var maximumRunners = capacityOfTrack * days;
                if (maximumRunners < runnersCount)
                {
                    var totalKM = ((maximumRunners * averageLapsPerRunner) * trackLength) / 1000;
                    moneyRaised = totalKM * donationPerKM;
                }
                else
                {
                    var totalM = ((runnersCount * averageLapsPerRunner) * trackLength);
                    var totalKM = totalM / 1000;
                    moneyRaised = totalKM * donationPerKM;
                }

            }
            else
            {
                var totalM = ((runnersCount * days)* trackLength) ;
                var totalKM = totalM / 1000;
                moneyRaised = totalKM * donationPerKM;
            }
        }
    }
}
