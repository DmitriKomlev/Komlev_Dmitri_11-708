using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y=ax+b");
            int a,b;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            int x, y, temp;
            x = 3;
            y = a * x ;
            Console.WriteLine("вектор, имеющий начало в точке (0;0) и параллельный данной прямой, проходит через координату (" + x + ";" + y+").");
            temp = y;
            y = -x;
            x = temp;
            Console.WriteLine("вектор, имеющий начало в точке (0;0) и перпендикулярный данной прямой, проходит через координату (" + x + ";" + y + ").");
            Console.ReadLine();

        }
    }
}
