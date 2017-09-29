using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cound3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTicket = int.Parse(Console.ReadLine());
            if (((numOfTicket + 1) % 10 + ((numOfTicket + 1) / 10) % 10 + ((numOfTicket + 1) / 100) % 10 == ((numOfTicket + 1) / 1000) % 10 + ((numOfTicket + 1) / 10000) % 10 + ((numOfTicket + 1) / 100000)) ||
                    ((numOfTicket - 1) % 10 + ((numOfTicket - 1) / 10) % 10 + ((numOfTicket - 1) / 100) % 10 == ((numOfTicket - 1) / 1000) % 10 + ((numOfTicket - 1) / 10000) % 10 + ((numOfTicket - 1) / 100000)))
                Console.WriteLine("true");
            else
                Console.WriteLine("true");
            Console.ReadKey();
        }
    }
}
