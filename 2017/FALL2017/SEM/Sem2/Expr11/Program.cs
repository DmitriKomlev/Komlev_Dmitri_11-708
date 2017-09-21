using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr10
{
    class Program
    {//Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            if (hour >= 12) hour -= 12;
            min *= 6;
            hour *= 30;
            int delta;
            if (hour>min)
            {
                delta = hour - min;
            }
            else
            {
                delta = min - hour;
            }
            if (delta > 180) delta = 360 - delta;
            Console.WriteLine(delta);
            Console.ReadLine();
        }
    }
}
