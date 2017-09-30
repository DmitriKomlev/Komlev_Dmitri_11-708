using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cound6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A(x1;y1)");
            Console.Write("x1=");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1=");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("B(x2;y2)");
            Console.Write("x2=");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2=");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("C(x3;y3)");
            Console.Write("x3=");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y3=");
            int y3 = int.Parse(Console.ReadLine());
            int temp = 0;
            if ((x1 == x2) && (x2 != x3) && (y1 != y2) && (y2 == y3)) Console.WriteLine("D("+x3 + ", " + y1+")");
            else temp++;
            if ((x1 == x3) && (x2 != x3) && (y1 != y3) && (y2 == y3)) Console.WriteLine("D("+x2 + ", " + y1+")");
            else temp++;
            if ((x1 == x2) && (x1 != x3) && (y1 != y2) && (y1 == y3)) Console.WriteLine("D("+x3 + ", " + y2+")");
            else temp++;
            if ((x3 == x2) && (x1 != x3) && (y3 != y2) && (y1 == y3)) Console.WriteLine("D("+x1 + ", " + y2+")");
            else temp++;
            if ((x3 == x2) && (x2 != x1) && (y3 != y2) && (y2 == y1)) Console.WriteLine("D("+x3 + ", " + y1+")");
            else temp++;
            if ((x3 == x1) && (x2 != x1) && (y3 != y1) && (y2 == y1)) Console.WriteLine(x3 + ", " + y2);
            else temp++;
            if (temp == 6) Console.WriteLine("this points don`t belong to the square");
            Console.ReadLine();
        }
    }
}
