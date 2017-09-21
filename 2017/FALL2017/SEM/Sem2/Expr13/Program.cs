using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr13
{
    class Program
    {//пусти козла в огород. дан квадрат и окружность с одним центром. найти площадь их пересечения 
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            double r, a;
            a = double.Parse(str.Substring(0, str.IndexOf(' ')));
            str = str.Substring(str.IndexOf(' ') + 1);
            r = double.Parse(str);
            if (a/2>=r)
            {
                Console.WriteLine(Math.Round(r * r * Math.PI,3));
            }
            else
            {
                if (Math.Pow(r,2)-Math.Pow(a/2,2)>=Math.Pow(a/2,2) )
                {
                    Console.WriteLine(Math.Pow(a, 2));
                }
                else
                {
                    Double x,alpha;
                    x = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(a / 2, 2));
                    alpha =2* Math.Asin(x / r);
                    double s;
                    s = Math.Pow(r, 2) * Math.PI - 4 * 0.5 * (alpha  - Math.Sin(alpha)) * Math.Pow(r, 2); 
                    Console.WriteLine(Math.Round(s,3));
                }
            }
            Console.ReadLine();
        }
    }
}
