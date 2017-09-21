using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr1
{
    class Program
    {//перестановка чисел местами
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            a = a - b; //без использования 3ей переменной
            b = b + a; 
            a = b - a; 
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
