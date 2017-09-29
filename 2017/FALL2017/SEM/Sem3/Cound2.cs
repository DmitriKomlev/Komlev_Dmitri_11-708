using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cound2
{
    class Program
    {
        public static double Min(double x, double y, double z)
        {
            return Math.Min(Math.Min(x, y), z);
        }
        public static double Middle(double x, double y, double z)
        {
            if (x > y)
                if (y > z) return y;
                else if (x > z) return z;
                else return x;
            else
        if (z < x) return x;
            else if (y > z) return z;
            else return y;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length, width and height of the bar:");
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            double z = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter length, width of the hole:");
            double x1 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());
            if ((Min(x, z, y) <= Math.Min(x1, y1)) && (Middle(x, y, z) <= Math.Max(x1, y1))) Console.WriteLine("true");
            else Console.WriteLine("false");
            Console.ReadKey();
        }
    }
}
