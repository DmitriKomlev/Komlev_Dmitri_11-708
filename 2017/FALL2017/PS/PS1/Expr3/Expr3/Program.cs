using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            if (a<12) 
            {                           //вычисляем угол для чисел <12
                if (a<=6) 
                {
                    Console.WriteLine(a*30);
                }
                else
                {
                    Console.WriteLine((12-a) * 30);
                }
            }
            else
            {                           //вычисляем угол для чисел >12
                a -= 12;
                if (a <= 6)
                {
                    Console.WriteLine(a * 30);
                }
                else
                {
                    Console.WriteLine((12 - a) * 30);
                }
            }
            Console.ReadLine();

        }
    }
}
