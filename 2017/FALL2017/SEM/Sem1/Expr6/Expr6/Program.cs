using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, x1, y1, x2, y2;
            Console.WriteLine("X координата точки:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Y координата точки:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("X координата первой точки, принадлежащей прямой:");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Y координата первой точки, принадлежащей прямой:");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("X координата второй точки, принадлежащей прямой:");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Y координата второй точки, принадлежащей прямой:");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine((Math.Abs((y2-y1)*x-(x2-x1)*y+x2*y1-y2*x1))/(Math.Sqrt(Math.Pow((y2-y1),2)+Math.Pow((x2-x1),2))));
            Console.ReadLine();
        }
    }
}
