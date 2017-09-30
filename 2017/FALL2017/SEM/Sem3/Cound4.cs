using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cound4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("начало 1 отрезка: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("конец 1 отрезка: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("начало 2 отрезка: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("конец 2 отрезка: ");
            double d = double.Parse(Console.ReadLine());
            double length =  Math.Max(0, (Math.Min(b, d) - Math.Max(a, c)));
            Console.WriteLine(length);
            Console.ReadLine();
        }
    }
}
