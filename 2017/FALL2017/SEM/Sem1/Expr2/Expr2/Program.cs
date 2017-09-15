using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,x; // универсальный код( подходит не только для 3х значных чисел)
            string a1;
            a = int.Parse(Console.ReadLine());
            a1 = a.ToString();

            x = a1.Length;
            string a2=null;
            for (int i = x - 1; i >= 0; i--)
            {
                a2 = a2 + a1[i];
            }
            a = int.Parse(a2);
            Console.WriteLine(a);
            Console.ReadLine();
            //int a;                    // подходит только для 3хзначных чисел без изменения а
            //a = 123;
            //int b = (a / 100);
            //b = (a / 100) + (((a % 100) / 10) * 10) + ((a % 10) * 100);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.ReadLine();

        }
    }
}
