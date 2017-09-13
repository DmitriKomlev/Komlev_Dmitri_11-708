using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, v;
            a = int.Parse(Console.ReadLine()); //читаем 1 дату
            b = int.Parse(Console.ReadLine()); // читаем 2 дату
            v = (b - a) / 4 - (b - a) / 100 + (b - a) / 400; //находим сумму кол-ва чисел с промежутка [a,b] кратных 4, кратных 400 и вычитаем из нее числа кол-во чисел кратных 100
            Console.WriteLine(v); // вывод
            Console.ReadLine();

        }
    }
}
