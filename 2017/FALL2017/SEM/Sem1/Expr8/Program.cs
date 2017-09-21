using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr8
{
    class Program
    {//Дана прямая L и точка A. Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A

        static void Main(string[] args)
        {

            Console.WriteLine("y=ax+b");
            double a, b;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки, через которую нужно провести перпендикуляр к прямой: ");
            double x0, y0;
            Console.Write("x=");
            x0 = int.Parse(Console.ReadLine());
            Console.Write("y=");
            y0 = int.Parse(Console.ReadLine());
            double a2=Math.Round(-1/a,2); // находим коэфф. прямой, перпендикулярной данной
            double b2 = Math.Round((y0 - a2 * x0),2); // находим смещение перпендикуляра
            double x = Math.Round(((b2 - b) / (a - a2)),2); // находим х коордитату точки пересечения 2х прямых
            double y = Math.Round((x * a2 + b2),2);// находим у коордитату точки пересечения 2х прямых
            Console.WriteLine("Точка пересечения заданной прямой и ее перпендикуляра: ({0};{1})",x,y);
            Console.ReadLine();
        }
    }
}
