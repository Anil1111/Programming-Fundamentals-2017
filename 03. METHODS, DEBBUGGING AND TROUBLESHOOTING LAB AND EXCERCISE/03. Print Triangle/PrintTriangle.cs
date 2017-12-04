using System;

namespace PrintTriangle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                PrintLine(i);
            }


            for (int i = n - 1; i > 0; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }


}



