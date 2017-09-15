using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            int y = int.Parse(Console.ReadLine());
            int k=0;
            //for (int i =1; i<=n; i++)
            //{
            //    if ((i%x==0) | (i%y==0))
            //    {
            //        k++;
            //    }
            //}
            int temp;
            temp = ((n-1) / x)+((n-1)/y)-(n-1)/(x*y);
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
