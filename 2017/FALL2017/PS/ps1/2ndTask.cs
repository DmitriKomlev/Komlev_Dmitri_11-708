using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1Ex2
{
    class Program
    {
        public static double Exponentation(double foundation, int exponent)
        {//возведение в степень не кратную 2
            double temp = 1;
            for (int i =1; i<=exponent;i++)

            {
                temp *= foundation;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter foundation of degree: ");
            double foundation = Double.Parse(Console.ReadLine());
            Console.Write("Enter exponent: ");
            int exponent = int.Parse(Console.ReadLine());
            while( exponent %2 ==0)
            {
                
                foundation *= foundation;
                exponent /= 2;
            }
            foundation = Exponentation(foundation, exponent);
            Console.WriteLine(foundation);
            Console.ReadLine();

        }
    }
}
