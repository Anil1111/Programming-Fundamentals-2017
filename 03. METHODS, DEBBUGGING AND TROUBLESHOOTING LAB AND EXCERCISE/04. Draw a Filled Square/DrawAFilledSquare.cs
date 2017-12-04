﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            DrawSquare(n);
        
        }

        private static void DrawSquare(int n)
        {
            PrintTopBottomLine(n);
            PrintMiddelRow(n);
            PrintMiddelRow(n);
            PrintTopBottomLine(n);
        }

        private static void PrintMiddelRow(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        private static void PrintTopBottomLine(int n)
        {
            Console.WriteLine(new string('-',2 * n));
        }
    }
}
