//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Globalization;


//   class Program
//  {
//        static void Main(string[] args)
//    {
      
//        DateTime startDate = DateTime.ParseExact(Console.ReadLine(),"dd-M-yyy",CultureInfo.InvariantCulture);
//        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-M-yyy", CultureInfo.InvariantCulture);
//        var officialHolidays = new string[]
//        {
//            "1 01",
//            "3 03",
//            "1 05",
//            "6 05",
//            "24 05",
//            "6 09",
//            "22 09",
//            "1 11",
//            "24 12",
//            "25 12",
//            "26 12",

//        }.Select(x => DateTime.ParseExact(x,"dd MM",CultureInfo.InvariantCulture));

//        var workingCountDays = 0;
//        for (var i = startDate; i <= endDate; i = i.AddDays(1))
//        {
//            var isWeekend = i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday;
//           var isHoliday = officialHolidays.Select(d => d.Day == i.Day && d.Month == i.Month);

//            var isWorkinDay = false;
//            if (isWorkinDay)
//            { workingCountDays++; }
//        }

//    }

//}

