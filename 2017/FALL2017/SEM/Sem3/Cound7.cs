using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cound7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Y=");
            double y = double.Parse(Console.ReadLine());
            int n1;
            n1 =(int)Math.Floor((x - y) * n / (y - 1)) + 1;
            Console.WriteLine(n1);
            Console.ReadLine();
        }
    }
}
