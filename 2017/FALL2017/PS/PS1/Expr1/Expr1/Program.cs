using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            a = a - b; //A= delta(a,b)
            b = b + a; // b = b + delta
            a = b - a; // a = b- delta
            Console.WriteLine("a = " + a + " b = " + b);
            Console.ReadLine();
            int c; // альтернативное решение
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a = " + a + " b = " + b);
            Console.ReadLine();
        }
    }
}
