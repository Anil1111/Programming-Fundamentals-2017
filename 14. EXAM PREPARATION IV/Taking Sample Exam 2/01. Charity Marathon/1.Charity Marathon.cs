using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taking_Sample_Exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = double.Parse(Console.ReadLine());
            var runnersCount = double.Parse(Console.ReadLine());
            var lapsPerRunner = double.Parse(Console.ReadLine());
            var track = double.Parse(Console.ReadLine());
            var capacity = double.Parse(Console.ReadLine());
            var donation = double.Parse(Console.ReadLine());

            var capacityPerWholeEvent = capacity * days;

            if (runnersCount < capacityPerWholeEvent)
            {
                var willRun = runnersCount;
                var totalMeters = willRun * lapsPerRunner * track;
                var totalKM = totalMeters / 1000;
                var moneyRaised = totalKM * donation;
                Console.WriteLine($"Money raised: {moneyRaised}");
            }
            else
            {
                var willRun = capacity * days;
                var totalMeters = willRun * lapsPerRunner * track;
                var totalKM = totalMeters / 1000;
                var moneyRaised = totalKM * donation;
                Console.WriteLine($"Money raised: {moneyRaised}");
            }
        }
    }
}
