using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sem2ex1
{
    class Program
    {
        //выполнил Комлев Дмитрий
        //Задача: вычислить сумму ряда (Cos(x))
        public static double[] CalculateSum(double eps, double x)
        {
            double sum=0, elem=1;
            int step = 1;
            sbyte sign = 1;
            while(Math.Abs(elem)>=eps)
            {
                sum += sign * elem;
                elem *= x * x / (2 * step * (2 * step - 1));
                sign *= -1;
                step++;
            }
            return new double[] { sum, step - 1 };
        }
        static void Main(string[] args)
        {
            double eps, x;
            x = double.Parse(Console.ReadLine());
            eps = double.Parse(Console.ReadLine());
            double[] answer =   CalculateSum(eps, x);
            Console.WriteLine("значение {0} достигается на {1} шаге", answer[0], answer[1]);
            Console.ReadLine();
        }
    }
}
