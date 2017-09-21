using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            double h, t, v, x;
            h = double.Parse(str.Substring(0, str.IndexOf(' ')));
            str = str.Substring(str.IndexOf(' ') + 1);
            t = double.Parse(str.Substring(0, str.IndexOf(' ')));
            str = str.Substring(str.IndexOf(' ') + 1);
            v = double.Parse(str.Substring(0, str.IndexOf(' ')));
            str = str.Substring(str.IndexOf(' ') + 1);
            x = double.Parse(str);
            double tmax, tmin;
            if(h/x>t)
            {
                tmax = t;
            }
            else
            {
                tmax = h / x;
            }

            tmin = (h - x * t) / (v - x); ;
            Console.WriteLine(tmin + " " + tmax);
            Console.ReadLine();

        }
    }
}
