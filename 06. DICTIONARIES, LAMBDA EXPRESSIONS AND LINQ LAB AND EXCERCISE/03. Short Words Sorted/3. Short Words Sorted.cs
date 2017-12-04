﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ', '.' },StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = input.OrderBy(x => x).Where(x => x.Length < 5).Distinct().ToList();
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
