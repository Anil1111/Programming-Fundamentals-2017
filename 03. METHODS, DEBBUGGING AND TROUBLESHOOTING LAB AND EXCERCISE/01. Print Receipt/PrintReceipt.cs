using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class PrintReceipt
    {
        static void Main(string[] args)
        {
            PrintReciept();
        }

        private static void PrintReciept()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------\n\u00A9 SoftUni");
        }

        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
    }
}
